namespace QR_C_Sharp_Test
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbQRInput = new System.Windows.Forms.Label();
            this.txtQRInputBox = new System.Windows.Forms.TextBox();
            this.gbQROutput = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCreateQR = new System.Windows.Forms.Button();
            this.btnQRSave = new System.Windows.Forms.Button();
            this.cbQRLevel = new System.Windows.Forms.ComboBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.cbEncodeMode = new System.Windows.Forms.ComboBox();
            this.lbEncodeMode = new System.Windows.Forms.Label();
            this.btnUploadLogo = new System.Windows.Forms.Button();
            this.gbQROutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQRInput
            // 
            this.lbQRInput.AutoSize = true;
            this.lbQRInput.Location = new System.Drawing.Point(49, 46);
            this.lbQRInput.Name = "lbQRInput";
            this.lbQRInput.Size = new System.Drawing.Size(53, 12);
            this.lbQRInput.TabIndex = 0;
            this.lbQRInput.Text = "生成内容";
            // 
            // txtQRInputBox
            // 
            this.txtQRInputBox.Location = new System.Drawing.Point(128, 46);
            this.txtQRInputBox.Name = "txtQRInputBox";
            this.txtQRInputBox.Size = new System.Drawing.Size(284, 21);
            this.txtQRInputBox.TabIndex = 1;
            // 
            // gbQROutput
            // 
            this.gbQROutput.Controls.Add(this.pictureBox1);
            this.gbQROutput.Location = new System.Drawing.Point(38, 137);
            this.gbQROutput.Name = "gbQROutput";
            this.gbQROutput.Size = new System.Drawing.Size(376, 258);
            this.gbQROutput.TabIndex = 2;
            this.gbQROutput.TabStop = false;
            this.gbQROutput.Text = "二维码";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(102, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 155);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCreateQR
            // 
            this.btnCreateQR.Location = new System.Drawing.Point(23, 410);
            this.btnCreateQR.Name = "btnCreateQR";
            this.btnCreateQR.Size = new System.Drawing.Size(75, 23);
            this.btnCreateQR.TabIndex = 3;
            this.btnCreateQR.Text = "生成";
            this.btnCreateQR.UseVisualStyleBackColor = true;
            this.btnCreateQR.Click += new System.EventHandler(this.btnCreateQR_Click);
            // 
            // btnQRSave
            // 
            this.btnQRSave.Location = new System.Drawing.Point(339, 410);
            this.btnQRSave.Name = "btnQRSave";
            this.btnQRSave.Size = new System.Drawing.Size(75, 23);
            this.btnQRSave.TabIndex = 4;
            this.btnQRSave.Text = "保存";
            this.btnQRSave.UseVisualStyleBackColor = true;
            this.btnQRSave.Click += new System.EventHandler(this.btnQRSave_Click);
            // 
            // cbQRLevel
            // 
            this.cbQRLevel.FormattingEnabled = true;
            this.cbQRLevel.Location = new System.Drawing.Point(128, 84);
            this.cbQRLevel.Name = "cbQRLevel";
            this.cbQRLevel.Size = new System.Drawing.Size(51, 20);
            this.cbQRLevel.TabIndex = 5;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(21, 87);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(101, 12);
            this.lbLevel.TabIndex = 6;
            this.lbLevel.Text = "Correction Level";
            // 
            // cbEncodeMode
            // 
            this.cbEncodeMode.FormattingEnabled = true;
            this.cbEncodeMode.Location = new System.Drawing.Point(293, 87);
            this.cbEncodeMode.Name = "cbEncodeMode";
            this.cbEncodeMode.Size = new System.Drawing.Size(95, 20);
            this.cbEncodeMode.TabIndex = 7;
            // 
            // lbEncodeMode
            // 
            this.lbEncodeMode.AutoSize = true;
            this.lbEncodeMode.Location = new System.Drawing.Point(214, 90);
            this.lbEncodeMode.Name = "lbEncodeMode";
            this.lbEncodeMode.Size = new System.Drawing.Size(71, 12);
            this.lbEncodeMode.TabIndex = 8;
            this.lbEncodeMode.Text = "Encode Mode";
            // 
            // btnUploadLogo
            // 
            this.btnUploadLogo.Location = new System.Drawing.Point(23, 108);
            this.btnUploadLogo.Name = "btnUploadLogo";
            this.btnUploadLogo.Size = new System.Drawing.Size(99, 23);
            this.btnUploadLogo.TabIndex = 9;
            this.btnUploadLogo.Text = "上传LOGO图片";
            this.btnUploadLogo.UseVisualStyleBackColor = true;
            this.btnUploadLogo.Click += new System.EventHandler(this.btnUploadLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 464);
            this.Controls.Add(this.btnUploadLogo);
            this.Controls.Add(this.lbEncodeMode);
            this.Controls.Add(this.cbEncodeMode);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.cbQRLevel);
            this.Controls.Add(this.btnQRSave);
            this.Controls.Add(this.btnCreateQR);
            this.Controls.Add(this.gbQROutput);
            this.Controls.Add(this.txtQRInputBox);
            this.Controls.Add(this.lbQRInput);
            this.Name = "Form1";
            this.Text = "生成二维码";
            this.gbQROutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQRInput;
        private System.Windows.Forms.TextBox txtQRInputBox;
        private System.Windows.Forms.GroupBox gbQROutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCreateQR;
        private System.Windows.Forms.Button btnQRSave;
        private System.Windows.Forms.ComboBox cbQRLevel;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.ComboBox cbEncodeMode;
        private System.Windows.Forms.Label lbEncodeMode;
        private System.Windows.Forms.Button btnUploadLogo;
    }
}

