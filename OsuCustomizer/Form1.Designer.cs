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
            btnMenuStable = new BotaoArredondado();
            btnMenuBlur = new BotaoArredondado();
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
            SuspendLayout();
            // 
            // pnlStable
            // 
            pnlStable.BackColor = Color.Transparent;
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
            pnlStable.Location = new Point(86, 0);
            pnlStable.Name = "pnlStable";
            pnlStable.Size = new Size(500, 500);
            pnlStable.TabIndex = 22;
            // 
            // numWhite
            // 
            numWhite.Location = new Point(291, 443);
            numWhite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numWhite.Name = "numWhite";
            numWhite.Size = new Size(37, 23);
            numWhite.TabIndex = 47;
            numWhite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numWhite.ValueChanged += numWhite_ValueChanged;
            // 
            // numSizeDecay
            // 
            numSizeDecay.Location = new Point(291, 392);
            numSizeDecay.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numSizeDecay.Name = "numSizeDecay";
            numSizeDecay.Size = new Size(37, 23);
            numSizeDecay.TabIndex = 46;
            numSizeDecay.ValueChanged += numSizeDecay_ValueChanged;
            // 
            // numDecay
            // 
            numDecay.Location = new Point(291, 341);
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
            numOpacity.Location = new Point(291, 290);
            numOpacity.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numOpacity.Name = "numOpacity";
            numOpacity.Size = new Size(37, 23);
            numOpacity.TabIndex = 44;
            numOpacity.ValueChanged += numOpacity_ValueChanged;
            // 
            // numBarBlur
            // 
            numBarBlur.Location = new Point(285, 239);
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
            numTrail.Location = new Point(285, 188);
            numTrail.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numTrail.Name = "numTrail";
            numTrail.Size = new Size(37, 23);
            numTrail.TabIndex = 42;
            numTrail.ValueChanged += numTrail_ValueChanged;
            // 
            // btnInjetar
            // 
            btnInjetar.BackColor = Color.DarkGray;
            btnInjetar.BackgroundImageLayout = ImageLayout.Center;
            btnInjetar.Cursor = Cursors.Hand;
            btnInjetar.FlatAppearance.BorderColor = Color.Silver;
            btnInjetar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            btnInjetar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnInjetar.FlatStyle = FlatStyle.Flat;
            btnInjetar.ForeColor = SystemColors.ControlText;
            btnInjetar.Location = new Point(29, 12);
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
            label6.Location = new Point(334, 443);
            label6.Name = "label6";
            label6.Size = new Size(153, 15);
            label6.TabIndex = 41;
            label6.Text = "<- Tamanho da bola branca";
            // 
            // chkUseImages
            // 
            chkUseImages.AutoSize = true;
            chkUseImages.Location = new Point(397, 47);
            chkUseImages.Name = "chkUseImages";
            chkUseImages.Size = new Size(81, 19);
            chkUseImages.TabIndex = 23;
            chkUseImages.Text = "Use Image";
            chkUseImages.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 392);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 40;
            label5.Text = "<- Afinamento do Trail";
            // 
            // btnImgCursor
            // 
            btnImgCursor.Location = new Point(375, 71);
            btnImgCursor.Name = "btnImgCursor";
            btnImgCursor.Size = new Size(110, 36);
            btnImgCursor.TabIndex = 24;
            btnImgCursor.Text = "Cursor.png";
            btnImgCursor.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 341);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 39;
            label4.Text = "<- Velocidade do trail";
            // 
            // btnImgTrail
            // 
            btnImgTrail.Location = new Point(375, 113);
            btnImgTrail.Name = "btnImgTrail";
            btnImgTrail.Size = new Size(110, 36);
            btnImgTrail.TabIndex = 25;
            btnImgTrail.Text = "Cursortrail.png";
            btnImgTrail.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 290);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 38;
            label3.Text = "<- Opacidade Cursor";
            // 
            // btnCorCursor
            // 
            btnCorCursor.Location = new Point(39, 105);
            btnCorCursor.Name = "btnCorCursor";
            btnCorCursor.Size = new Size(110, 36);
            btnCorCursor.TabIndex = 26;
            btnCorCursor.Text = "Cor do Cursor";
            btnCorCursor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 239);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 37;
            label2.Text = "<- Tamanho do Cursor";
            // 
            // btnCorTrail
            // 
            btnCorTrail.Location = new Point(155, 105);
            btnCorTrail.Name = "btnCorTrail";
            btnCorTrail.Size = new Size(110, 36);
            btnCorTrail.TabIndex = 27;
            btnCorTrail.Text = "Cor do Trail";
            btnCorTrail.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 190);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 36;
            label1.Text = "<- Tamanho do Trail";
            label1.Click += label1_Click;
            // 
            // chkBloom
            // 
            chkBloom.AutoSize = true;
            chkBloom.Location = new Point(39, 164);
            chkBloom.Name = "chkBloom";
            chkBloom.Size = new Size(61, 19);
            chkBloom.TabIndex = 28;
            chkBloom.Text = "Bloom";
            chkBloom.UseVisualStyleBackColor = true;
            // 
            // trackBarWhite
            // 
            trackBarWhite.Location = new Point(15, 443);
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
            chkWhiteCenter.Location = new Point(106, 164);
            chkWhiteCenter.Name = "chkWhiteCenter";
            chkWhiteCenter.Size = new Size(95, 19);
            chkWhiteCenter.TabIndex = 29;
            chkWhiteCenter.Text = "White Center";
            chkWhiteCenter.UseVisualStyleBackColor = true;
            // 
            // trackBarSizeDecay
            // 
            trackBarSizeDecay.Location = new Point(15, 392);
            trackBarSizeDecay.Maximum = 100;
            trackBarSizeDecay.Minimum = -50;
            trackBarSizeDecay.Name = "trackBarSizeDecay";
            trackBarSizeDecay.Size = new Size(270, 45);
            trackBarSizeDecay.TabIndex = 34;
            trackBarSizeDecay.Value = 1;
            // 
            // trackBarTrail
            // 
            trackBarTrail.Location = new Point(9, 189);
            trackBarTrail.Maximum = 500;
            trackBarTrail.Name = "trackBarTrail";
            trackBarTrail.Size = new Size(270, 45);
            trackBarTrail.TabIndex = 30;
            trackBarTrail.Scroll += trackBarTrail_Scroll;
            // 
            // trackBarDecay
            // 
            trackBarDecay.Location = new Point(15, 341);
            trackBarDecay.Maximum = 150;
            trackBarDecay.Minimum = 1;
            trackBarDecay.Name = "trackBarDecay";
            trackBarDecay.Size = new Size(270, 45);
            trackBarDecay.TabIndex = 33;
            trackBarDecay.Value = 1;
            // 
            // trackBarBlur
            // 
            trackBarBlur.Location = new Point(9, 239);
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
            trackBarOpacity.Location = new Point(15, 290);
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
            pnlBlur.Location = new Point(83, 3);
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
            // btnMenuStable
            // 
            btnMenuStable.BackColor = SystemColors.ButtonShadow;
            btnMenuStable.FlatAppearance.BorderColor = Color.Gray;
            btnMenuStable.FlatAppearance.BorderSize = 0;
            btnMenuStable.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMenuStable.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMenuStable.FlatStyle = FlatStyle.Flat;
            btnMenuStable.Font = new Font("Segoe UI", 8F);
            btnMenuStable.Location = new Point(9, 20);
            btnMenuStable.Name = "btnMenuStable";
            btnMenuStable.Size = new Size(65, 36);
            btnMenuStable.TabIndex = 24;
            btnMenuStable.Text = "Stable cursor";
            btnMenuStable.UseVisualStyleBackColor = false;
            btnMenuStable.Click += btnMenuStable_Click;
            // 
            // btnMenuBlur
            // 
            btnMenuBlur.BackColor = SystemColors.ButtonShadow;
            btnMenuBlur.FlatAppearance.BorderColor = Color.Gray;
            btnMenuBlur.FlatAppearance.BorderSize = 0;
            btnMenuBlur.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMenuBlur.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnMenuBlur.FlatStyle = FlatStyle.Flat;
            btnMenuBlur.Font = new Font("Segoe UI", 8F);
            btnMenuBlur.Location = new Point(9, 62);
            btnMenuBlur.Name = "btnMenuBlur";
            btnMenuBlur.Size = new Size(65, 36);
            btnMenuBlur.TabIndex = 25;
            btnMenuBlur.Text = "Stable blur";
            btnMenuBlur.UseVisualStyleBackColor = false;
            btnMenuBlur.Click += btnMenuBlur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 561);
            Controls.Add(btnMenuBlur);
            Controls.Add(btnMenuStable);
            Controls.Add(pnlBlur);
            Controls.Add(pnlStable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Osu Custom Trail Builder";
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
    }
}
