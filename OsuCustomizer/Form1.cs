using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace OsuCustomizer
{
    public partial class Form1 : Form
    {
        private MemoryMappedFile _mmf = null!;
        private MemoryMappedViewAccessor _accessor = null!;
        private CursorSettings _currentSettings;

        private readonly string ConfigFilePath = "config.json";

        public Form1()
        {
            InitializeComponent();




            btnCorCursor.Click += btnCorCursor_Click;
            btnCorTrail.Click += btnCorTrail_Click;
            btnImgCursor.Click += btnImgCursor_Click;
            btnImgTrail.Click += btnImgTrail_Click;


            chkUseImages.CheckedChanged += chkUseImages_CheckedChanged;
            chkBloom.CheckedChanged += chkBloom_CheckedChanged;
            chkWhiteCenter.CheckedChanged += chkWhiteCenter_CheckedChanged;
            if (chkMotionBlur != null) chkMotionBlur.CheckedChanged += chkMotionBlur_CheckedChanged;


            trackBarTrail.Scroll += trackBarTrail_Scroll_1;
            trackBarBlur.Scroll += trackBarBlur_Scroll;
            trackBarOpacity.Scroll += trackBarOpacity_Scroll;
            trackBarDecay.Scroll += trackBarDecay_Scroll;
            trackBarSizeDecay.Scroll += trackBarSizeDecay_Scroll;
            trackBarWhite.Scroll += trackBarWhite_Scroll;
            if (trackBarBlurIntensity != null) trackBarBlurIntensity.Scroll += trackBarBlurIntensity_Scroll;
        }

        private void SetupMemory()
        {
            _mmf = MemoryMappedFile.CreateOrOpen("OsuCursorSettings", Marshal.SizeOf<CursorSettings>());
            _accessor = _mmf.CreateViewAccessor();
        }

        private void InitDefaults()
        {
            _currentSettings = new CursorSettings
            {
                trail_length = 40,
                blur_size = 15.0f,
                max_opacity = 255.0f,
                opacity_decay = 3.0f,
                size_decay = 0.0f,
                use_images = false,
                white_center_ratio = 0.70f,
                cursor_r = 0.3f,
                cursor_g = 0.9f,
                cursor_b = 0.7f,
                trail_r = 0.3f,
                trail_g = 0.9f,
                trail_b = 0.7f,
                cursor_image_path = "",
                trail_image_path = "",
                enable_motion_blur = false,
                blur_intensity = 0.5f
            };

            UpdateUIFromSettings();
            UpdateSharedMemory();
        }

        private void LoadConfig()
        {
            if (File.Exists(ConfigFilePath))
            {
                try
                {
                    string json = File.ReadAllText(ConfigFilePath);
                    var options = new JsonSerializerOptions { IncludeFields = true };
                    _currentSettings = JsonSerializer.Deserialize<CursorSettings>(json, options);

                    UpdateUIFromSettings();
                    UpdateSharedMemory();
                }
                catch
                {
                    InitDefaults();
                }
            }
            else
            {
                InitDefaults();
            }
        }

        private void SaveConfig()
        {
            var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            string json = JsonSerializer.Serialize(_currentSettings, options);
            File.WriteAllText(ConfigFilePath, json);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveConfig();
            base.OnFormClosing(e);
        }

        private void UpdateUIFromSettings()
        {
            trackBarTrail.Value = Math.Clamp(_currentSettings.trail_length, trackBarTrail.Minimum, trackBarTrail.Maximum);
            trackBarBlur.Value = Math.Clamp((int)_currentSettings.blur_size, trackBarBlur.Minimum, trackBarBlur.Maximum);
            trackBarOpacity.Value = Math.Clamp((int)_currentSettings.max_opacity, trackBarOpacity.Minimum, trackBarOpacity.Maximum);
            trackBarDecay.Value = Math.Clamp((int)(_currentSettings.opacity_decay * 10), trackBarDecay.Minimum, trackBarDecay.Maximum);
            trackBarSizeDecay.Value = Math.Clamp((int)(_currentSettings.size_decay * 10), trackBarSizeDecay.Minimum, trackBarSizeDecay.Maximum);
            trackBarWhite.Value = Math.Clamp((int)(_currentSettings.white_center_ratio * 100), trackBarWhite.Minimum, trackBarWhite.Maximum);

            chkUseImages.Checked = _currentSettings.use_images;
            chkBloom.Checked = _currentSettings.enable_glow;
            chkWhiteCenter.Checked = _currentSettings.enable_white_center;


            if (chkMotionBlur != null) chkMotionBlur.Checked = _currentSettings.enable_motion_blur;
            if (trackBarBlurIntensity != null) trackBarBlurIntensity.Value = Math.Clamp((int)(_currentSettings.blur_intensity * 100), trackBarBlurIntensity.Minimum, trackBarBlurIntensity.Maximum);
        }

        private void UpdateSharedMemory()
        {
            _currentSettings.cursor_image_path ??= "";
            _currentSettings.trail_image_path ??= "";

            int size = Marshal.SizeOf(typeof(CursorSettings));
            byte[] buffer = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.StructureToPtr(_currentSettings, ptr, false);
                Marshal.Copy(ptr, buffer, 0, size);
                _accessor.WriteArray(0, buffer, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }


        private void InjetarDLL(string nomeDaDll)
        {
            string dllPath = Path.GetFullPath(nomeDaDll);
            string injetorPath = Path.GetFullPath("injetor.exe");

            if (File.Exists(injetorPath) && File.Exists(dllPath))
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = injetorPath;
                psi.Arguments = $"\"{dllPath}\"";
                psi.UseShellExecute = true;
                psi.Verb = "runas";

                using (Process proc = Process.Start(psi))
                {
                    proc.WaitForExit();
                    int exitCode = proc.ExitCode;

                    if (exitCode != 0)
                    {
                        if (exitCode == 2) MessageBox.Show("JOGO NÃO ENCONTRADO!\n\nAbra o osu! primeiro antes de injetar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else MessageBox.Show($"FALHA {nomeDaDll} Exitcode: {exitCode}", "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show($"{nomeDaDll} ou Ijetor.exe não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //  injeção dlls
        private void btnInjetar_Click(object sender, EventArgs e)
        {
            try
            {

                InjetarDLL("dlldinamica.dll");


                System.Threading.Thread.Sleep(500);


                InjetarDLL("MotionBlur.dll");

                MessageBox.Show("SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.ComponentModel.Win32Exception)
            {
                MessageBox.Show("Cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImgCursor_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens PNG|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentSettings.cursor_image_path = ofd.FileName;
                    _currentSettings.use_images = true;
                    chkUseImages.Checked = true;
                    UpdateSharedMemory();
                }
            }
        }

        private void btnImgTrail_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imagens PNG|*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentSettings.trail_image_path = ofd.FileName;
                    _currentSettings.use_images = true;
                    chkUseImages.Checked = true;
                    UpdateSharedMemory();
                }
            }
        }

        private void btnCorCursor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _currentSettings.cursor_r = cd.Color.R / 255.0f;
                    _currentSettings.cursor_g = cd.Color.G / 255.0f;
                    _currentSettings.cursor_b = cd.Color.B / 255.0f;
                    UpdateSharedMemory();
                }
            }
        }

        private void btnCorTrail_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _currentSettings.trail_r = cd.Color.R / 255.0f;
                    _currentSettings.trail_g = cd.Color.G / 255.0f;
                    _currentSettings.trail_b = cd.Color.B / 255.0f;
                    UpdateSharedMemory();
                }
            }
        }

        private void chkUseImages_CheckedChanged(object sender, EventArgs e) { _currentSettings.use_images = chkUseImages.Checked; UpdateSharedMemory(); }
        private void chkBloom_CheckedChanged(object sender, EventArgs e) { _currentSettings.enable_glow = chkBloom.Checked; UpdateSharedMemory(); }
        private void chkWhiteCenter_CheckedChanged(object sender, EventArgs e) { _currentSettings.enable_white_center = chkWhiteCenter.Checked; UpdateSharedMemory(); }
        private void trackBarTrail_Scroll_1(object sender, EventArgs e) { _currentSettings.trail_length = trackBarTrail.Value; UpdateSharedMemory(); }

        private void chkMotionBlur_CheckedChanged(object sender, EventArgs e) { _currentSettings.enable_motion_blur = chkMotionBlur.Checked; UpdateSharedMemory(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SetupMemory();
                LoadConfig();
                MostrarPainel(pnlStable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar memória: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarPainel(Panel painelAtivo)
        {
            if (pnlStable != null) pnlStable.Visible = false;
            if (pnlBlur != null) pnlBlur.Visible = false;

            if (painelAtivo != null)
            {
                painelAtivo.Visible = true;
                painelAtivo.BringToFront();
            }
        }


        private void btnMenuBlur_Click(object sender, EventArgs e) { MostrarPainel(pnlBlur); }





        private void trackBarBlurIntensity_Scroll(object sender, EventArgs e)
        {

            numBlurIntensity.Value = trackBarBlurIntensity.Value;

            _currentSettings.blur_intensity = trackBarBlurIntensity.Value / 100.0f;
            UpdateSharedMemory();
        }


        private void numBlurIntensity_ValueChanged(object sender, EventArgs e)
        {

            trackBarBlurIntensity.Value = (int)numBlurIntensity.Value;

            _currentSettings.blur_intensity = trackBarBlurIntensity.Value / 100.0f;
            UpdateSharedMemory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numTrail_ValueChanged(object sender, EventArgs e)
        {
            trackBarTrail.Value = (int)numTrail.Value;
            _currentSettings.trail_length = trackBarTrail.Value;
            UpdateSharedMemory();
        }

        private void trackBarTrail_Scroll(object sender, EventArgs e)
        {
            {
                numTrail.Value = trackBarTrail.Value;
                _currentSettings.trail_length = trackBarTrail.Value;
                UpdateSharedMemory();
            }
        }

        private void trackBarBlur_Scroll(object sender, EventArgs e)
        {

            numBarBlur.Value = trackBarBlur.Value;
            _currentSettings.blur_size = (float)trackBarBlur.Value;
            UpdateSharedMemory();
        }

        private void numBarBlur_ValueChanged(object sender, EventArgs e)
        {
            trackBarBlur.Value = (int)numBarBlur.Value;
            _currentSettings.blur_size = (float)trackBarBlur.Value;
            UpdateSharedMemory();
        }


        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {

            numOpacity.Value = trackBarOpacity.Value;
            _currentSettings.max_opacity = (float)trackBarOpacity.Value;
            UpdateSharedMemory();
        }

        private void numOpacity_ValueChanged(object sender, EventArgs e)
        {
            trackBarOpacity.Value = (int)numOpacity.Value;
            _currentSettings.max_opacity = (float)trackBarOpacity.Value;
            UpdateSharedMemory();
        }


        private void trackBarDecay_Scroll(object sender, EventArgs e)
        {

            numDecay.Value = trackBarDecay.Value;
            _currentSettings.opacity_decay = trackBarDecay.Value / 10.0f;
            UpdateSharedMemory();
        }


        private void numDecay_ValueChanged(object sender, EventArgs e)
        {
            trackBarDecay.Value = (int)numDecay.Value;
            _currentSettings.opacity_decay = trackBarDecay.Value / 10.0f;
            UpdateSharedMemory();
        }


        private void trackBarSizeDecay_Scroll(object sender, EventArgs e)
        {

            numSizeDecay.Value = trackBarSizeDecay.Value;
            _currentSettings.size_decay = trackBarSizeDecay.Value / 10.0f;
            UpdateSharedMemory();
        }
        private void numSizeDecay_ValueChanged(object sender, EventArgs e)
        {
            trackBarSizeDecay.Value = (int)numSizeDecay.Value;
            _currentSettings.size_decay = trackBarSizeDecay.Value / 10.0f;
            UpdateSharedMemory();
        }
        private void trackBarWhite_Scroll(object sender, EventArgs e)
        {
            numWhite.Value = trackBarWhite.Value;
            _currentSettings.white_center_ratio = trackBarWhite.Value / 100.0f;
            UpdateSharedMemory();
        }

        private void numWhite_ValueChanged(object sender, EventArgs e)
        {
            trackBarWhite.Value = (int)numWhite.Value;
            _currentSettings.white_center_ratio = trackBarWhite.Value / 100.0f;
            UpdateSharedMemory();
        }

        private void chkMotionBlur_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnMenuStable_Click(object sender, EventArgs e)
        {
            MostrarPainel(pnlStable);
        }

        private void btnMenuBlur_Click_1(object sender, EventArgs e)
        {
            MostrarPainel(pnlBlur);
        }

        private void btnPanelLzr_Click(object sender, EventArgs e)
        {
            MostrarPainel(pnlLazerDX11);
        }

        private void btnInjetarLazerDX11_Click(object sender, EventArgs e)
        {
            string dllPath = Path.GetFullPath("osulazerdx11.dll");
            string injetorPath = Path.GetFullPath("injetor64.exe");

            if (File.Exists(injetorPath) && File.Exists(dllPath))
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = injetorPath;
                psi.Arguments = $"\"{dllPath}\""; // Passa a DLL de forma invisível
                psi.UseShellExecute = true;
                psi.Verb = "runas"; // Pede permissão de Administrador

                // Se usar UseShellExecute = false, daria pra esconder a janela do CMD 100%, 
                // mas o 'runas' obriga a ser true. A janela preta vai piscar por 0.1s e fechar.

                using (Process proc = Process.Start(psi))
                {
                    proc.WaitForExit();
                    int exitCode = proc.ExitCode;

                    // Lendo a resposta silenciosa do injetor64.exe
                    if (exitCode == 0)
                    {
                        MessageBox.Show("SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (exitCode == 2)
                    {
                        MessageBox.Show("OSU! LAZER NÃO ENCONTRADO!\n\nAbra o jogo primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show($"FALHA NA INJEÇÃO Código: {exitCode})", "Erro Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("A DLL 'osulazerdx11.dll' ou o 'injetor64.exe' não foram encontrados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInjetarOpenGL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EM DESENVOLVIMENTO, USE DX11!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}