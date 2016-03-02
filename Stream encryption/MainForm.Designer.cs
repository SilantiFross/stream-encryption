namespace Stream_encryption
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.radioButtonOne = new System.Windows.Forms.RadioButton();
            this.radioButtonScheme = new System.Windows.Forms.RadioButton();
            this.radioButtonRC4 = new System.Windows.Forms.RadioButton();
            this.labelLFSR1 = new System.Windows.Forms.Label();
            this.textBoxLSFR1 = new System.Windows.Forms.TextBox();
            this.textBoxLFSR2 = new System.Windows.Forms.TextBox();
            this.labelLFSR2 = new System.Windows.Forms.Label();
            this.textBoxLFSR3 = new System.Windows.Forms.TextBox();
            this.labelLFSR3 = new System.Windows.Forms.Label();
            this.labelRC4Key = new System.Windows.Forms.Label();
            this.textBoxRC4Key = new System.Windows.Forms.TextBox();
            this.labelLFSR1Length = new System.Windows.Forms.Label();
            this.labelLFSR2Length = new System.Windows.Forms.Label();
            this.labelLFSR3Length = new System.Windows.Forms.Label();
            this.labelRC4Length = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open file";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 44);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(447, 571);
            this.textBoxInput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(762, 44);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(447, 571);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Enabled = false;
            this.buttonConvert.Location = new System.Drawing.Point(494, 592);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(76, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // radioButtonOne
            // 
            this.radioButtonOne.AutoSize = true;
            this.radioButtonOne.Location = new System.Drawing.Point(470, 58);
            this.radioButtonOne.Name = "radioButtonOne";
            this.radioButtonOne.Size = new System.Drawing.Size(82, 17);
            this.radioButtonOne.TabIndex = 6;
            this.radioButtonOne.Text = "One register";
            this.radioButtonOne.UseVisualStyleBackColor = true;
            this.radioButtonOne.CheckedChanged += new System.EventHandler(this.radioButtonOne_CheckedChanged);
            // 
            // radioButtonScheme
            // 
            this.radioButtonScheme.AutoSize = true;
            this.radioButtonScheme.Location = new System.Drawing.Point(470, 81);
            this.radioButtonScheme.Name = "radioButtonScheme";
            this.radioButtonScheme.Size = new System.Drawing.Size(93, 17);
            this.radioButtonScheme.TabIndex = 7;
            this.radioButtonScheme.Text = "Scheme Geffe";
            this.radioButtonScheme.UseVisualStyleBackColor = true;
            this.radioButtonScheme.CheckedChanged += new System.EventHandler(this.radioButtonScheme_CheckedChanged);
            // 
            // radioButtonRC4
            // 
            this.radioButtonRC4.AutoSize = true;
            this.radioButtonRC4.Location = new System.Drawing.Point(470, 104);
            this.radioButtonRC4.Name = "radioButtonRC4";
            this.radioButtonRC4.Size = new System.Drawing.Size(46, 17);
            this.radioButtonRC4.TabIndex = 8;
            this.radioButtonRC4.Text = "RC4";
            this.radioButtonRC4.UseVisualStyleBackColor = true;
            this.radioButtonRC4.CheckedChanged += new System.EventHandler(this.radioButtonRC4_CheckedChanged);
            // 
            // labelLFSR1
            // 
            this.labelLFSR1.AutoSize = true;
            this.labelLFSR1.Location = new System.Drawing.Point(467, 154);
            this.labelLFSR1.Name = "labelLFSR1";
            this.labelLFSR1.Size = new System.Drawing.Size(43, 13);
            this.labelLFSR1.TabIndex = 11;
            this.labelLFSR1.Text = "LFSR1:";
            this.labelLFSR1.Visible = false;
            // 
            // textBoxLSFR1
            // 
            this.textBoxLSFR1.Location = new System.Drawing.Point(470, 170);
            this.textBoxLSFR1.MaxLength = 23;
            this.textBoxLSFR1.Name = "textBoxLSFR1";
            this.textBoxLSFR1.Size = new System.Drawing.Size(286, 20);
            this.textBoxLSFR1.TabIndex = 12;
            this.textBoxLSFR1.Visible = false;
            this.textBoxLSFR1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLSFR1_KeyPress);
            this.textBoxLSFR1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLSFR1_KeyUp);
            // 
            // textBoxLFSR2
            // 
            this.textBoxLFSR2.Location = new System.Drawing.Point(470, 209);
            this.textBoxLFSR2.MaxLength = 31;
            this.textBoxLFSR2.Name = "textBoxLFSR2";
            this.textBoxLFSR2.Size = new System.Drawing.Size(286, 20);
            this.textBoxLFSR2.TabIndex = 14;
            this.textBoxLFSR2.Visible = false;
            this.textBoxLFSR2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLFSR2_KeyPress);
            this.textBoxLFSR2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLFSR2_KeyUp);
            // 
            // labelLFSR2
            // 
            this.labelLFSR2.AutoSize = true;
            this.labelLFSR2.Location = new System.Drawing.Point(467, 193);
            this.labelLFSR2.Name = "labelLFSR2";
            this.labelLFSR2.Size = new System.Drawing.Size(43, 13);
            this.labelLFSR2.TabIndex = 13;
            this.labelLFSR2.Text = "LFSR2:";
            this.labelLFSR2.Visible = false;
            // 
            // textBoxLFSR3
            // 
            this.textBoxLFSR3.Location = new System.Drawing.Point(470, 248);
            this.textBoxLFSR3.MaxLength = 39;
            this.textBoxLFSR3.Name = "textBoxLFSR3";
            this.textBoxLFSR3.Size = new System.Drawing.Size(286, 20);
            this.textBoxLFSR3.TabIndex = 16;
            this.textBoxLFSR3.Visible = false;
            this.textBoxLFSR3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLFSR3_KeyPress);
            this.textBoxLFSR3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxLFSR3_KeyUp);
            // 
            // labelLFSR3
            // 
            this.labelLFSR3.AutoSize = true;
            this.labelLFSR3.Location = new System.Drawing.Point(467, 232);
            this.labelLFSR3.Name = "labelLFSR3";
            this.labelLFSR3.Size = new System.Drawing.Size(43, 13);
            this.labelLFSR3.TabIndex = 15;
            this.labelLFSR3.Text = "LFSR3:";
            this.labelLFSR3.Visible = false;
            // 
            // labelRC4Key
            // 
            this.labelRC4Key.AutoSize = true;
            this.labelRC4Key.Location = new System.Drawing.Point(467, 154);
            this.labelRC4Key.Name = "labelRC4Key";
            this.labelRC4Key.Size = new System.Drawing.Size(52, 13);
            this.labelRC4Key.TabIndex = 17;
            this.labelRC4Key.Text = "RC4 Key:";
            this.labelRC4Key.Visible = false;
            // 
            // textBoxRC4Key
            // 
            this.textBoxRC4Key.Location = new System.Drawing.Point(470, 170);
            this.textBoxRC4Key.Multiline = true;
            this.textBoxRC4Key.Name = "textBoxRC4Key";
            this.textBoxRC4Key.Size = new System.Drawing.Size(286, 289);
            this.textBoxRC4Key.TabIndex = 18;
            this.textBoxRC4Key.Visible = false;
            this.textBoxRC4Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRC4Key_KeyPress);
            // 
            // labelLFSR1Length
            // 
            this.labelLFSR1Length.AutoSize = true;
            this.labelLFSR1Length.Location = new System.Drawing.Point(692, 154);
            this.labelLFSR1Length.Name = "labelLFSR1Length";
            this.labelLFSR1Length.Size = new System.Drawing.Size(46, 13);
            this.labelLFSR1Length.TabIndex = 19;
            this.labelLFSR1Length.Text = "Length: ";
            this.labelLFSR1Length.Visible = false;
            // 
            // labelLFSR2Length
            // 
            this.labelLFSR2Length.AutoSize = true;
            this.labelLFSR2Length.Location = new System.Drawing.Point(692, 193);
            this.labelLFSR2Length.Name = "labelLFSR2Length";
            this.labelLFSR2Length.Size = new System.Drawing.Size(46, 13);
            this.labelLFSR2Length.TabIndex = 20;
            this.labelLFSR2Length.Text = "Length: ";
            this.labelLFSR2Length.Visible = false;
            // 
            // labelLFSR3Length
            // 
            this.labelLFSR3Length.AutoSize = true;
            this.labelLFSR3Length.Location = new System.Drawing.Point(692, 232);
            this.labelLFSR3Length.Name = "labelLFSR3Length";
            this.labelLFSR3Length.Size = new System.Drawing.Size(46, 13);
            this.labelLFSR3Length.TabIndex = 21;
            this.labelLFSR3Length.Text = "Length: ";
            this.labelLFSR3Length.Visible = false;
            // 
            // labelRC4Length
            // 
            this.labelRC4Length.AutoSize = true;
            this.labelRC4Length.Location = new System.Drawing.Point(692, 154);
            this.labelRC4Length.Name = "labelRC4Length";
            this.labelRC4Length.Size = new System.Drawing.Size(46, 13);
            this.labelRC4Length.TabIndex = 22;
            this.labelRC4Length.Text = "Length: ";
            this.labelRC4Length.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1221, 638);
            this.Controls.Add(this.labelRC4Length);
            this.Controls.Add(this.labelLFSR1Length);
            this.Controls.Add(this.radioButtonRC4);
            this.Controls.Add(this.radioButtonScheme);
            this.Controls.Add(this.radioButtonOne);
            this.Controls.Add(this.textBoxRC4Key);
            this.Controls.Add(this.labelRC4Key);
            this.Controls.Add(this.textBoxLFSR3);
            this.Controls.Add(this.labelLFSR3);
            this.Controls.Add(this.textBoxLFSR2);
            this.Controls.Add(this.labelLFSR2);
            this.Controls.Add(this.textBoxLSFR1);
            this.Controls.Add(this.labelLFSR1);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.labelLFSR3Length);
            this.Controls.Add(this.labelLFSR2Length);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Stream encrypted";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.RadioButton radioButtonScheme;
        private System.Windows.Forms.RadioButton radioButtonRC4;
        private System.Windows.Forms.Label labelLFSR1;
        private System.Windows.Forms.TextBox textBoxLSFR1;
        private System.Windows.Forms.TextBox textBoxLFSR2;
        private System.Windows.Forms.Label labelLFSR2;
        private System.Windows.Forms.TextBox textBoxLFSR3;
        private System.Windows.Forms.Label labelLFSR3;
        private System.Windows.Forms.Label labelRC4Key;
        private System.Windows.Forms.TextBox textBoxRC4Key;
        private System.Windows.Forms.RadioButton radioButtonOne;
        private System.Windows.Forms.Label labelLFSR1Length;
        private System.Windows.Forms.Label labelLFSR2Length;
        private System.Windows.Forms.Label labelLFSR3Length;
        private System.Windows.Forms.Label labelRC4Length;
    }
}

