namespace OsuCustomizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlStable = new Panel();
            txtFPS = new TextBox();
            btnAplicarFPS = new Button();
            numWhite = new NumericUpDown();
            numSizeDecay = new NumericUpDown();
            numDecay = new NumericUpDown();
            numOpacity = new NumericUpDown();
            numBarBlur = new NumericUpDown();
            numTrail = new NumericUpDown();
            btnInjetar = new Button();
            label6 = new Label();
            chkUseImages = new CheckBox();
            label5 = new Label();
            btnImgCursor = new Button();
            label4 = new Label();
            btnImgTrail = new Button();
            label3 = new Label();
            btnCorCursor = new Button();
            label2 = new Label();
            btnCorTrail = new Button();
            label1 = new Label();
            chkBloom = new CheckBox();
            trackBarWhite = new TrackBar();
            chkWhiteCenter = new CheckBox();
            trackBarSizeDecay = new TrackBar();
            trackBarTrail = new TrackBar();
            trackBarDecay = new TrackBar();
            trackBarBlur = new TrackBar();
            trackBarOpacity = new TrackBar();
            pnlBlur = new Panel();
            numBlurIntensity = new NumericUpDown();
            trackBarBlurIntensity = new TrackBar();
            chkMotionBlur = new CheckBox();
            label7 = new Label();
            pnlLazerDX11 = new Panel();
            btnInjetarOpenGL = new Button();
            btnInjetarLazerDX11 = new Button();
            btnMenuStable = new BotaoArredondado();
            btnMenuBlur = new BotaoArredondado();
            btnPanelLzr = new BotaoArredondado();
            label8 = new Label();
            label9 = new Label();
            pnlStable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSizeDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOpacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTrail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWhite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSizeDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDecay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarOpacity).BeginInit();
            pnlBlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBlurIntensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlurIntensity).BeginInit();
            pnlLazerDX11.SuspendLayout();
            SuspendLayout();
            // 
            // pnlStable
            // 
            pnlStable.BackColor = Color.Transparent;
            pnlStable.Controls.Add(label9);
            pnlStable.Controls.Add(label8);
            pnlStable.Controls.Add(txtFPS);
            pnlStable.Controls.Add(btnAplicarFPS);
            pnlStable.Controls.Add(numWhite);
            pnlStable.Controls.Add(numSizeDecay);
            pnlStable.Controls.Add(numDecay);
            pnlStable.Controls.Add(numOpacity);
            pnlStable.Controls.Add(numBarBlur);
            pnlStable.Controls.Add(numTrail);
            pnlStable.Controls.Add(btnInjetar);
            pnlStable.Controls.Add(label6);
            pnlStable.Controls.Add(chkUseImages);
            pnlStable.Controls.Add(label5);
            pnlStable.Controls.Add(btnImgCursor);
            pnlStable.Controls.Add(label4);
            pnlStable.Controls.Add(btnImgTrail);
            pnlStable.Controls.Add(label3);
            pnlStable.Controls.Add(btnCorCursor);
            pnlStable.Controls.Add(label2);
            pnlStable.Controls.Add(btnCorTrail);
            pnlStable.Controls.Add(label1);
            pnlStable.Controls.Add(chkBloom);
            pnlStable.Controls.Add(trackBarWhite);
            pnlStable.Controls.Add(chkWhiteCenter);
            pnlStable.Controls.Add(trackBarSizeDecay);
            pnlStable.Controls.Add(trackBarTrail);
            pnlStable.Controls.Add(trackBarDecay);
            pnlStable.Controls.Add(trackBarBlur);
            pnlStable.Controls.Add(trackBarOpacity);
            pnlStable.Location = new Point(82, 2);
            pnlStable.Name = "pnlStable";
            pnlStable.Size = new Size(500, 600);
            pnlStable.TabIndex = 22;
            // 
            // txtFPS
            // 
            txtFPS.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            txtFPS.Location = new Point(235, 461);
            txtFPS.Multiline = true;
            txtFPS.Name = "txtFPS";
            txtFPS.Size = new Size(120, 36);
            txtFPS.TabIndex = 49;
            // 
            // btnAplicarFPS
            // 
            btnAplicarFPS.BackColor = Color.Black;
            btnAplicarFPS.BackgroundImage = Properties.Resources.botão_110x36;
            btnAplicarFPS.Cursor = Cursors.Hand;
            btnAplicarFPS.FlatAppearance.BorderColor = Color.Blue;
            btnAplicarFPS.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnAplicarFPS.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnAplicarFPS.FlatStyle = FlatStyle.Flat;
            btnAplicarFPS.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnAplicarFPS.ForeColor = SystemColors.Control;
            btnAplicarFPS.Location = new Point(370, 461);
            btnAplicarFPS.Name = "btnAplicarFPS";
            btnAplicarFPS.Size = new Size(110, 36);
            btnAplicarFPS.TabIndex = 48;
            btnAplicarFPS.Text = "Aplicar";
            btnAplicarFPS.UseVisualStyleBackColor = false;
            btnAplicarFPS.Click += btnAplicarFPS_Click;
            // 
            // numWhite
            // 
            numWhite.Location = new Point(285, 375);
            numWhite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numWhite.Name = "numWhite";
            numWhite.Size = new Size(37, 23);
            numWhite.TabIndex = 47;
            numWhite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numWhite.ValueChanged += numWhite_ValueChanged;
            // 
            // numSizeDecay
            // 
            numSizeDecay.Location = new Point(285, 324);
            numSizeDecay.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numSizeDecay.Name = "numSizeDecay";
            numSizeDecay.Size = new Size(37, 23);
            numSizeDecay.TabIndex = 46;
            numSizeDecay.ValueChanged += numSizeDecay_ValueChanged;
            // 
            // numDecay
            // 
            numDecay.Location = new Point(285, 273);
            numDecay.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            numDecay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDecay.Name = "numDecay";
            numDecay.Size = new Size(37, 23);
            numDecay.TabIndex = 45;
            numDecay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numDecay.ValueChanged += numDecay_ValueChanged;
            // 
            // numOpacity
            // 
            numOpacity.Location = new Point(285, 222);
            numOpacity.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numOpacity.Name = "numOpacity";
            numOpacity.Size = new Size(37, 23);
            numOpacity.TabIndex = 44;
            numOpacity.ValueChanged += numOpacity_ValueChanged;
            // 
            // numBarBlur
            // 
            numBarBlur.Location = new Point(285, 171);
            numBarBlur.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numBarBlur.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numBarBlur.Name = "numBarBlur";
            numBarBlur.Size = new Size(37, 23);
            numBarBlur.TabIndex = 43;
            numBarBlur.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numBarBlur.ValueChanged += numBarBlur_ValueChanged;
            // 
            // numTrail
            // 
            numTrail.Location = new Point(285, 120);
            numTrail.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numTrail.Name = "numTrail";
            numTrail.Size = new Size(37, 23);
            numTrail.TabIndex = 42;
            numTrail.ValueChanged += numTrail_ValueChanged;
            // 
            // btnInjetar
            // 
            btnInjetar.BackColor = Color.MediumBlue;
            btnInjetar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInjetar.Cursor = Cursors.Hand;
            btnInjetar.FlatAppearance.BorderColor = Color.Silver;
            btnInjetar.FlatAppearance.BorderSize = 0;
            btnInjetar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnInjetar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInjetar.FlatStyle = FlatStyle.Flat;
            btnInjetar.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnInjetar.ForeColor = SystemColors.Control;
            btnInjetar.Image = Properties.Resources.botão_172x38;
            btnInjetar.Location = new Point(9, 9);
            btnInjetar.Margin = new Padding(0);
            btnInjetar.Name = "btnInjetar";
            btnInjetar.Size = new Size(172, 38);
            btnInjetar.TabIndex = 22;
            btnInjetar.Text = "Injetar";
            btnInjetar.UseVisualStyleBackColor = false;
            btnInjetar.Click += btnInjetar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(325, 377);
            label6.Name = "label6";
            label6.Size = new Size(172, 15);
            label6.TabIndex = 41;
            label6.Text = "<- Tamanho da bola branca";
            // 
            // chkUseImages
            // 
            chkUseImages.AutoSize = true;
            chkUseImages.Location = new Point(360, 29);
            chkUseImages.Name = "chkUseImages";
            chkUseImages.Size = new Size(81, 19);
            chkUseImages.TabIndex = 23;
            chkUseImages.Text = "Use Image";
            chkUseImages.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(334, 324);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 40;
            label5.Text = "<- Afinamento do Trail";
            // 
            // btnImgCursor
            // 
            btnImgCursor.BackColor = Color.Black;
            btnImgCursor.BackgroundImage = Properties.Resources.botão_110x36;
            btnImgCursor.Cursor = Cursors.Hand;
            btnImgCursor.FlatAppearance.BorderColor = Color.Blue;
            btnImgCursor.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnImgCursor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnImgCursor.FlatStyle = FlatStyle.Flat;
            btnImgCursor.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnImgCursor.ForeColor = SystemColors.Control;
            btnImgCursor.Location = new Point(250, 59);
            btnImgCursor.Name = "btnImgCursor";
            btnImgCursor.Size = new Size(110, 36);
            btnImgCursor.TabIndex = 24;
            btnImgCursor.Text = "Cursor.png";
            btnImgCursor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(334, 273);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 39;
            label4.Text = "<- Velocidade do trail";
            // 
            // btnImgTrail
            // 
            btnImgTrail.BackColor = Color.Black;
            btnImgTrail.BackgroundImage = Properties.Resources.botão_110x36;
            btnImgTrail.Cursor = Cursors.Hand;
            btnImgTrail.FlatAppearance.BorderColor = Color.Blue;
            btnImgTrail.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnImgTrail.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnImgTrail.FlatStyle = FlatStyle.Flat;
            btnImgTrail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnImgTrail.ForeColor = SystemColors.Control;
            btnImgTrail.Location = new Point(370, 59);
            btnImgTrail.Name = "btnImgTrail";
            btnImgTrail.Size = new Size(110, 36);
            btnImgTrail.TabIndex = 25;
            btnImgTrail.Text = "Cursortrail.png";
            btnImgTrail.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(328, 222);
            label3.Name = "label3";
            label3.Size = new Size(131, 15);
            label3.TabIndex = 38;
            label3.Text = "<- Opacidade Cursor";
            // 
            // btnCorCursor
            // 
            btnCorCursor.BackColor = Color.Black;
            btnCorCursor.BackgroundImage = Properties.Resources.botão_110x36;
            btnCorCursor.Cursor = Cursors.Hand;
            btnCorCursor.FlatAppearance.BorderColor = Color.Blue;
            btnCorCursor.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnCorCursor.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnCorCursor.FlatStyle = FlatStyle.Flat;
            btnCorCursor.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnCorCursor.ForeColor = SystemColors.Control;
            btnCorCursor.Location = new Point(9, 59);
            btnCorCursor.Name = "btnCorCursor";
            btnCorCursor.Size = new Size(110, 36);
            btnCorCursor.TabIndex = 26;
            btnCorCursor.Text = "Cor do Cursor";
            btnCorCursor.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(328, 171);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 37;
            label2.Text = "<- Tamanho do Cursor";
            // 
            // btnCorTrail
            // 
            btnCorTrail.BackColor = Color.Black;
            btnCorTrail.BackgroundImage = Properties.Resources.botão_110x36;
            btnCorTrail.Cursor = Cursors.Hand;
            btnCorTrail.FlatAppearance.BorderColor = Color.Blue;
            btnCorTrail.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 64);
            btnCorTrail.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnCorTrail.FlatStyle = FlatStyle.Flat;
            btnCorTrail.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnCorTrail.ForeColor = SystemColors.Control;
            btnCorTrail.Location = new Point(125, 59);
            btnCorTrail.Name = "btnCorTrail";
            btnCorTrail.Size = new Size(110, 36);
            btnCorTrail.TabIndex = 27;
            btnCorTrail.Text = "Cor do Trail";
            btnCorTrail.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(328, 122);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 36;
            label1.Text = "<- Tamanho do Trail";
            label1.Click += label1_Click;
            // 
            // chkBloom
            // 
            chkBloom.AutoSize = true;
            chkBloom.Location = new Point(39, 96);
            chkBloom.Name = "chkBloom";
            chkBloom.Size = new Size(61, 19);
            chkBloom.TabIndex = 28;
            chkBloom.Text = "Bloom";
            chkBloom.UseVisualStyleBackColor = true;
            // 
            // trackBarWhite
            // 
            trackBarWhite.Location = new Point(9, 375);
            trackBarWhite.Maximum = 100;
            trackBarWhite.Minimum = 1;
            trackBarWhite.Name = "trackBarWhite";
            trackBarWhite.Size = new Size(270, 45);
            trackBarWhite.TabIndex = 35;
            trackBarWhite.Value = 1;
            // 
            // chkWhiteCenter
            // 
            chkWhiteCenter.AutoSize = true;
            chkWhiteCenter.Location = new Point(106, 96);
            chkWhiteCenter.Name = "chkWhiteCenter";
            chkWhiteCenter.Size = new Size(95, 19);
            chkWhiteCenter.TabIndex = 29;
            chkWhiteCenter.Text = "White Center";
            chkWhiteCenter.UseVisualStyleBackColor = true;
            // 
            // trackBarSizeDecay
            // 
            trackBarSizeDecay.Location = new Point(9, 324);
            trackBarSizeDecay.Maximum = 100;
            trackBarSizeDecay.Minimum = -50;
            trackBarSizeDecay.Name = "trackBarSizeDecay";
            trackBarSizeDecay.Size = new Size(270, 45);
            trackBarSizeDecay.TabIndex = 34;
            trackBarSizeDecay.Value = 1;
            // 
            // trackBarTrail
            // 
            trackBarTrail.Location = new Point(9, 121);
            trackBarTrail.Maximum = 500;
            trackBarTrail.Name = "trackBarTrail";
            trackBarTrail.Size = new Size(270, 45);
            trackBarTrail.TabIndex = 30;
            trackBarTrail.Scroll += trackBarTrail_Scroll;
            // 
            // trackBarDecay
            // 
            trackBarDecay.Location = new Point(9, 273);
            trackBarDecay.Maximum = 150;
            trackBarDecay.Minimum = 1;
            trackBarDecay.Name = "trackBarDecay";
            trackBarDecay.Size = new Size(270, 45);
            trackBarDecay.TabIndex = 33;
            trackBarDecay.Value = 1;
            // 
            // trackBarBlur
            // 
            trackBarBlur.Location = new Point(9, 171);
            trackBarBlur.Maximum = 300;
            trackBarBlur.Minimum = 1;
            trackBarBlur.Name = "trackBarBlur";
            trackBarBlur.Size = new Size(270, 45);
            trackBarBlur.TabIndex = 31;
            trackBarBlur.Value = 1;
            trackBarBlur.Scroll += trackBarBlur_Scroll;
            // 
            // trackBarOpacity
            // 
            trackBarOpacity.Location = new Point(9, 222);
            trackBarOpacity.Maximum = 255;
            trackBarOpacity.Name = "trackBarOpacity";
            trackBarOpacity.Size = new Size(270, 45);
            trackBarOpacity.TabIndex = 32;
            trackBarOpacity.Value = 1;
            // 
            // pnlBlur
            // 
            pnlBlur.BackColor = Color.Transparent;
            pnlBlur.Controls.Add(numBlurIntensity);
            pnlBlur.Controls.Add(trackBarBlurIntensity);
            pnlBlur.Controls.Add(chkMotionBlur);
            pnlBlur.Controls.Add(label7);
            pnlBlur.Location = new Point(82, 2);
            pnlBlur.Name = "pnlBlur";
            pnlBlur.Size = new Size(500, 500);
            pnlBlur.TabIndex = 23;
            // 
            // numBlurIntensity
            // 
            numBlurIntensity.Location = new Point(408, 165);
            numBlurIntensity.Name = "numBlurIntensity";
            numBlurIntensity.Size = new Size(39, 23);
            numBlurIntensity.TabIndex = 23;
            numBlurIntensity.ValueChanged += numBlurIntensity_ValueChanged;
            // 
            // trackBarBlurIntensity
            // 
            trackBarBlurIntensity.BackColor = SystemColors.AppWorkspace;
            trackBarBlurIntensity.Location = new Point(46, 165);
            trackBarBlurIntensity.Maximum = 100;
            trackBarBlurIntensity.Name = "trackBarBlurIntensity";
            trackBarBlurIntensity.Size = new Size(350, 45);
            trackBarBlurIntensity.TabIndex = 4;
            trackBarBlurIntensity.Scroll += trackBarBlurIntensity_Scroll;
            // 
            // chkMotionBlur
            // 
            chkMotionBlur.AutoSize = true;
            chkMotionBlur.Font = new Font("Segoe UI", 14F);
            chkMotionBlur.ForeColor = SystemColors.ButtonFace;
            chkMotionBlur.Location = new Point(68, 66);
            chkMotionBlur.Name = "chkMotionBlur";
            chkMotionBlur.Size = new Size(185, 29);
            chkMotionBlur.TabIndex = 3;
            chkMotionBlur.Text = "Ativar Motion Blur";
            chkMotionBlur.UseVisualStyleBackColor = true;
            chkMotionBlur.CheckedChanged += chkMotionBlur_CheckedChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(46, 121);
            label7.Name = "label7";
            label7.Size = new Size(187, 25);
            label7.TabIndex = 5;
            label7.Text = "Intensidade do Blur";
            // 
            // pnlLazerDX11
            // 
            pnlLazerDX11.BackColor = Color.Transparent;
            pnlLazerDX11.Controls.Add(btnInjetarOpenGL);
            pnlLazerDX11.Controls.Add(btnInjetarLazerDX11);
            pnlLazerDX11.Location = new Point(82, 2);
            pnlLazerDX11.Name = "pnlLazerDX11";
            pnlLazerDX11.Size = new Size(500, 500);
            pnlLazerDX11.TabIndex = 27;
            // 
            // btnInjetarOpenGL
            // 
            btnInjetarOpenGL.BackColor = Color.MediumBlue;
            btnInjetarOpenGL.BackgroundImageLayout = ImageLayout.Zoom;
            btnInjetarOpenGL.Cursor = Cursors.Hand;
            btnInjetarOpenGL.FlatAppearance.BorderColor = Color.Silver;
            btnInjetarOpenGL.FlatAppearance.BorderSize = 0;
            btnInjetarOpenGL.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnInjetarOpenGL.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInjetarOpenGL.FlatStyle = FlatStyle.Flat;
            btnInjetarOpenGL.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnInjetarOpenGL.ForeColor = SystemColors.Control;
            btnInjetarOpenGL.Image = Properties.Resources.botão_172x38;
            btnInjetarOpenGL.Location = new Point(291, 28);
            btnInjetarOpenGL.Margin = new Padding(0);
            btnInjetarOpenGL.Name = "btnInjetarOpenGL";
            btnInjetarOpenGL.Size = new Size(172, 38);
            btnInjetarOpenGL.TabIndex = 24;
            btnInjetarOpenGL.Text = "Injetar OpenGL";
            btnInjetarOpenGL.UseVisualStyleBackColor = false;
            btnInjetarOpenGL.Click += btnInjetarOpenGL_Click;
            // 
            // btnInjetarLazerDX11
            // 
            btnInjetarLazerDX11.BackColor = Color.MediumBlue;
            btnInjetarLazerDX11.BackgroundImageLayout = ImageLayout.Zoom;
            btnInjetarLazerDX11.Cursor = Cursors.Hand;
            btnInjetarLazerDX11.FlatAppearance.BorderColor = Color.Silver;
            btnInjetarLazerDX11.FlatAppearance.BorderSize = 0;
            btnInjetarLazerDX11.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnInjetarLazerDX11.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInjetarLazerDX11.FlatStyle = FlatStyle.Flat;
            btnInjetarLazerDX11.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            btnInjetarLazerDX11.ForeColor = SystemColors.Control;
            btnInjetarLazerDX11.Image = Properties.Resources.botão_172x38;
            btnInjetarLazerDX11.Location = new Point(34, 28);
            btnInjetarLazerDX11.Margin = new Padding(0);
            btnInjetarLazerDX11.Name = "btnInjetarLazerDX11";
            btnInjetarLazerDX11.Size = new Size(172, 38);
            btnInjetarLazerDX11.TabIndex = 23;
            btnInjetarLazerDX11.Text = "Injetar DX11";
            btnInjetarLazerDX11.UseVisualStyleBackColor = false;
            btnInjetarLazerDX11.Click += btnInjetarLazerDX11_Click;
            // 
            // btnMenuStable
            // 
            btnMenuStable.FlatAppearance.BorderColor = Color.Blue;
            btnMenuStable.FlatStyle = FlatStyle.Flat;
            btnMenuStable.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            btnMenuStable.ForeColor = SystemColors.ButtonHighlight;
            btnMenuStable.Image = Properties.Resources.botão_65x36;
            btnMenuStable.Location = new Point(12, 12);
            btnMenuStable.Name = "btnMenuStable";
            btnMenuStable.Size = new Size(65, 36);
            btnMenuStable.TabIndex = 28;
            btnMenuStable.Text = "Osu Stable";
            btnMenuStable.UseVisualStyleBackColor = true;
            btnMenuStable.Click += btnMenuStable_Click_1;
            // 
            // btnMenuBlur
            // 
            btnMenuBlur.FlatAppearance.BorderColor = Color.Blue;
            btnMenuBlur.FlatStyle = FlatStyle.Flat;
            btnMenuBlur.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            btnMenuBlur.ForeColor = SystemColors.Control;
            btnMenuBlur.Image = Properties.Resources.botão_65x36;
            btnMenuBlur.Location = new Point(11, 59);
            btnMenuBlur.Name = "btnMenuBlur";
            btnMenuBlur.Size = new Size(65, 36);
            btnMenuBlur.TabIndex = 29;
            btnMenuBlur.Text = "Blur Stable";
            btnMenuBlur.UseVisualStyleBackColor = true;
            btnMenuBlur.Click += btnMenuBlur_Click_2;
            // 
            // btnPanelLzr
            // 
            btnPanelLzr.FlatAppearance.BorderColor = Color.Blue;
            btnPanelLzr.FlatStyle = FlatStyle.Flat;
            btnPanelLzr.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            btnPanelLzr.ForeColor = SystemColors.Control;
            btnPanelLzr.Image = Properties.Resources.botão_65x36;
            btnPanelLzr.Location = new Point(12, 105);
            btnPanelLzr.Name = "btnPanelLzr";
            btnPanelLzr.Size = new Size(65, 36);
            btnPanelLzr.TabIndex = 30;
            btnPanelLzr.Text = "Osu Lazer";
            btnPanelLzr.UseVisualStyleBackColor = true;
            btnPanelLzr.Click += btnPanelLzr_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(106, 464);
            label8.Name = "label8";
            label8.Size = new Size(118, 15);
            label8.TabIndex = 50;
            label8.Text = "FPS do CursorTrail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(125, 479);
            label9.Name = "label9";
            label9.Size = new Size(84, 15);
            label9.TabIndex = 51;
            label9.Text = "0 = Ilimitado";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(584, 561);
            Controls.Add(btnPanelLzr);
            Controls.Add(btnMenuBlur);
            Controls.Add(btnMenuStable);
            Controls.Add(pnlStable);
            Controls.Add(pnlLazerDX11);
            Controls.Add(pnlBlur);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Name = "Form1";
            Text = "Osu Custom Cursor Builder";
            Load += Form1_Load;
            pnlStable.ResumeLayout(false);
            pnlStable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSizeDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOpacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBarBlur).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTrail).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarWhite).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarSizeDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTrail).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarDecay).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlur).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarOpacity).EndInit();
            pnlBlur.ResumeLayout(false);
            pnlBlur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBlurIntensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlurIntensity).EndInit();
            pnlLazerDX11.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnInjetarLazer_Click;
        private Panel pnlStable;
        private Button btnInjetar;
        private Label label6;
        private CheckBox chkUseImages;
        private Label label5;
        private Button btnImgCursor;
        private Label label4;
        private Button btnImgTrail;
        private Label label3;
        private Button btnCorCursor;
        private Label label2;
        private Button btnCorTrail;
        private Label label1;
        private CheckBox chkBloom;
        private TrackBar trackBarWhite;
        private CheckBox chkWhiteCenter;
        private TrackBar trackBarSizeDecay;
        private TrackBar trackBarTrail;
        private TrackBar trackBarDecay;
        private TrackBar trackBarBlur;
        private TrackBar trackBarOpacity;
        private Panel pnlBlur;
        private Label label7;
        private TrackBar trackBarBlurIntensity;
        private CheckBox chkMotionBlur;
        private NumericUpDown numBlurIntensity;
        private NumericUpDown numTrail;
        private NumericUpDown numWhite;
        private NumericUpDown numSizeDecay;
        private NumericUpDown numDecay;
        private NumericUpDown numOpacity;
        private NumericUpDown numBarBlur;
        private BotaoArredondado btnMenuStable;
        private BotaoArredondado btnMenuBlur;
        private BotaoArredondado btnPanelLzr;
        private Panel pnlLazerDX11;
        private Button btnInjetarLazerDX11;
        private Button btnInjetarOpenGL;
        private Button btnAplicarFPS;
        private TextBox txtFPS;
        private Label label9;
        private Label label8;
    }
}
