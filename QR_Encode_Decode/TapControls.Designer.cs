namespace QR_C_Sharp_Test
{
    partial class QREncode_Decode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QREncode_Decode));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbOptModeChoose = new System.Windows.Forms.GroupBox();
            this.rbOptModNormal = new System.Windows.Forms.RadioButton();
            this.rbOptModPro = new System.Windows.Forms.RadioButton();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.gb2InsertLogo = new System.Windows.Forms.GroupBox();
            this.btnInsertLogo = new System.Windows.Forms.Button();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.gbOutputQR = new System.Windows.Forms.GroupBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQRInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbErrorCorrection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbQRVersion = new System.Windows.Forms.ComboBox();
            this.cbEndoeMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateQR = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbQRDecodeOutput = new System.Windows.Forms.Label();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.btnChooseQR = new System.Windows.Forms.Button();
            this.btnDecodeQR = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbQRSize = new System.Windows.Forms.ComboBox();
            this.lbQRSize = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbOptModeChoose.SuspendLayout();
            this.gb2InsertLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.gbOutputQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 604);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbOptModeChoose);
            this.tabPage1.Controls.Add(this.btnSaveQR);
            this.tabPage1.Controls.Add(this.gb2InsertLogo);
            this.tabPage1.Controls.Add(this.gbOutputQR);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtQRInput);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnGenerateQR);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "生成二维码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbOptModeChoose
            // 
            this.gbOptModeChoose.Controls.Add(this.rbOptModNormal);
            this.gbOptModeChoose.Controls.Add(this.rbOptModPro);
            this.gbOptModeChoose.Location = new System.Drawing.Point(15, 39);
            this.gbOptModeChoose.Name = "gbOptModeChoose";
            this.gbOptModeChoose.Size = new System.Drawing.Size(522, 43);
            this.gbOptModeChoose.TabIndex = 13;
            this.gbOptModeChoose.TabStop = false;
            this.gbOptModeChoose.Text = "操作模式";
            this.gbOptModeChoose.Enter += new System.EventHandler(this.gbOptModeChoose_Enter);
            // 
            // rbOptModNormal
            // 
            this.rbOptModNormal.AutoSize = true;
            this.rbOptModNormal.Location = new System.Drawing.Point(330, 16);
            this.rbOptModNormal.Name = "rbOptModNormal";
            this.rbOptModNormal.Size = new System.Drawing.Size(71, 16);
            this.rbOptModNormal.TabIndex = 1;
            this.rbOptModNormal.TabStop = true;
            this.rbOptModNormal.Text = "一般模式";
            this.rbOptModNormal.UseVisualStyleBackColor = true;
            this.rbOptModNormal.CheckedChanged += new System.EventHandler(this.rbOptModNormal_CheckedChanged);
            // 
            // rbOptModPro
            // 
            this.rbOptModPro.AutoSize = true;
            this.rbOptModPro.Location = new System.Drawing.Point(71, 16);
            this.rbOptModPro.Name = "rbOptModPro";
            this.rbOptModPro.Size = new System.Drawing.Size(71, 16);
            this.rbOptModPro.TabIndex = 0;
            this.rbOptModPro.TabStop = true;
            this.rbOptModPro.Text = "专家模式";
            this.rbOptModPro.UseVisualStyleBackColor = true;
            this.rbOptModPro.CheckedChanged += new System.EventHandler(this.rbOptModPro_CheckedChanged);
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(462, 549);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQR.TabIndex = 12;
            this.btnSaveQR.Text = "保存二维码";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // gb2InsertLogo
            // 
            this.gb2InsertLogo.Controls.Add(this.btnInsertLogo);
            this.gb2InsertLogo.Controls.Add(this.picBox2);
            this.gb2InsertLogo.Location = new System.Drawing.Point(364, 192);
            this.gb2InsertLogo.Name = "gb2InsertLogo";
            this.gb2InsertLogo.Size = new System.Drawing.Size(191, 247);
            this.gb2InsertLogo.TabIndex = 11;
            this.gb2InsertLogo.TabStop = false;
            this.gb2InsertLogo.Text = "插入logo";
            // 
            // btnInsertLogo
            // 
            this.btnInsertLogo.Location = new System.Drawing.Point(14, 20);
            this.btnInsertLogo.Name = "btnInsertLogo";
            this.btnInsertLogo.Size = new System.Drawing.Size(88, 23);
            this.btnInsertLogo.TabIndex = 1;
            this.btnInsertLogo.Text = "选择LOGO图片";
            this.btnInsertLogo.UseVisualStyleBackColor = true;
            this.btnInsertLogo.Click += new System.EventHandler(this.btnInsertLogo_Click);
            // 
            // picBox2
            // 
            this.picBox2.Location = new System.Drawing.Point(7, 62);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(179, 179);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // gbOutputQR
            // 
            this.gbOutputQR.Controls.Add(this.picBox1);
            this.gbOutputQR.Location = new System.Drawing.Point(15, 181);
            this.gbOutputQR.Name = "gbOutputQR";
            this.gbOutputQR.Size = new System.Drawing.Size(343, 362);
            this.gbOutputQR.TabIndex = 10;
            this.gbOutputQR.TabStop = false;
            this.gbOutputQR.Text = "二维码";
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(7, 20);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(330, 332);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "二维码内容";
            // 
            // txtQRInput
            // 
            this.txtQRInput.Location = new System.Drawing.Point(95, 12);
            this.txtQRInput.Name = "txtQRInput";
            this.txtQRInput.Size = new System.Drawing.Size(442, 21);
            this.txtQRInput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbQRSize);
            this.groupBox1.Controls.Add(this.cbQRSize);
            this.groupBox1.Controls.Add(this.cbErrorCorrection);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbQRVersion);
            this.groupBox1.Controls.Add(this.cbEndoeMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "二维码生成选项";
            // 
            // cbErrorCorrection
            // 
            this.cbErrorCorrection.FormattingEnabled = true;
            this.cbErrorCorrection.Location = new System.Drawing.Point(87, 20);
            this.cbErrorCorrection.Name = "cbErrorCorrection";
            this.cbErrorCorrection.Size = new System.Drawing.Size(71, 20);
            this.cbErrorCorrection.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "二维码版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "容错级别";
            // 
            // cbQRVersion
            // 
            this.cbQRVersion.FormattingEnabled = true;
            this.cbQRVersion.Location = new System.Drawing.Point(421, 51);
            this.cbQRVersion.Name = "cbQRVersion";
            this.cbQRVersion.Size = new System.Drawing.Size(71, 20);
            this.cbQRVersion.TabIndex = 5;
            // 
            // cbEndoeMode
            // 
            this.cbEndoeMode.FormattingEnabled = true;
            this.cbEndoeMode.Location = new System.Drawing.Point(421, 15);
            this.cbEndoeMode.Name = "cbEndoeMode";
            this.cbEndoeMode.Size = new System.Drawing.Size(71, 20);
            this.cbEndoeMode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "二维码编码";
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(10, 549);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateQR.TabIndex = 0;
            this.btnGenerateQR.Text = "生成二维码";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnClipboard);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnChooseQR);
            this.tabPage2.Controls.Add(this.btnDecodeQR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "解析二维码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbQRDecodeOutput
            // 
            this.lbQRDecodeOutput.AutoSize = true;
            this.lbQRDecodeOutput.Location = new System.Drawing.Point(18, 22);
            this.lbQRDecodeOutput.Name = "lbQRDecodeOutput";
            this.lbQRDecodeOutput.Size = new System.Drawing.Size(0, 12);
            this.lbQRDecodeOutput.TabIndex = 5;
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(441, 539);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(92, 23);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "复制到剪贴板";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBox3);
            this.groupBox2.Location = new System.Drawing.Point(100, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 394);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "二维码";
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(22, 28);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(350, 350);
            this.picBox3.TabIndex = 0;
            this.picBox3.TabStop = false;
            // 
            // btnChooseQR
            // 
            this.btnChooseQR.Location = new System.Drawing.Point(10, 427);
            this.btnChooseQR.Name = "btnChooseQR";
            this.btnChooseQR.Size = new System.Drawing.Size(159, 23);
            this.btnChooseQR.TabIndex = 1;
            this.btnChooseQR.Text = "选择要解析的二维码图片";
            this.btnChooseQR.UseVisualStyleBackColor = true;
            this.btnChooseQR.Click += new System.EventHandler(this.btnChooseQR_Click);
            // 
            // btnDecodeQR
            // 
            this.btnDecodeQR.Location = new System.Drawing.Point(26, 539);
            this.btnDecodeQR.Name = "btnDecodeQR";
            this.btnDecodeQR.Size = new System.Drawing.Size(75, 23);
            this.btnDecodeQR.TabIndex = 0;
            this.btnDecodeQR.Text = "解释二维码";
            this.btnDecodeQR.UseVisualStyleBackColor = true;
            this.btnDecodeQR.Click += new System.EventHandler(this.btnDecodeQR_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbQRDecodeOutput);
            this.groupBox3.Location = new System.Drawing.Point(6, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "解析出的内容";
            // 
            // cbQRSize
            // 
            this.cbQRSize.FormattingEnabled = true;
            this.cbQRSize.Location = new System.Drawing.Point(85, 51);
            this.cbQRSize.Name = "cbQRSize";
            this.cbQRSize.Size = new System.Drawing.Size(71, 20);
            this.cbQRSize.TabIndex = 7;
            // 
            // lbQRSize
            // 
            this.lbQRSize.AutoSize = true;
            this.lbQRSize.Location = new System.Drawing.Point(12, 54);
            this.lbQRSize.Name = "lbQRSize";
            this.lbQRSize.Size = new System.Drawing.Size(65, 12);
            this.lbQRSize.TabIndex = 8;
            this.lbQRSize.Text = "二维码尺寸";
            // 
            // QREncode_Decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 638);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QREncode_Decode";
            this.Text = "QR二维码生成和解释工具";
            this.Load += new System.EventHandler(this.QREncode_Decode_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbOptModeChoose.ResumeLayout(false);
            this.gbOptModeChoose.PerformLayout();
            this.gb2InsertLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.gbOutputQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerateQR;
        private System.Windows.Forms.Button btnDecodeQR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbErrorCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbQRVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEndoeMode;
        private System.Windows.Forms.GroupBox gbOutputQR;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQRInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb2InsertLogo;
        private System.Windows.Forms.Button btnInsertLogo;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Button btnChooseQR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Label lbQRDecodeOutput;
        private System.Windows.Forms.GroupBox gbOptModeChoose;
        private System.Windows.Forms.RadioButton rbOptModNormal;
        private System.Windows.Forms.RadioButton rbOptModPro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbQRSize;
        private System.Windows.Forms.ComboBox cbQRSize;
    }
}