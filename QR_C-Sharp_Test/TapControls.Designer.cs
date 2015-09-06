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
            this.lbDecodeQR = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.btnChooseQR = new System.Windows.Forms.Button();
            this.btnDecodeQR = new System.Windows.Forms.Button();
            this.btnClipboard = new System.Windows.Forms.Button();
            this.lbQRDecodeOutput = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb2InsertLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.gbOutputQR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(475, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "生成二维码";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(318, 441);
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
            this.gb2InsertLogo.Location = new System.Drawing.Point(274, 202);
            this.gb2InsertLogo.Name = "gb2InsertLogo";
            this.gb2InsertLogo.Size = new System.Drawing.Size(191, 226);
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
            this.picBox2.Location = new System.Drawing.Point(14, 62);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(150, 150);
            this.picBox2.TabIndex = 0;
            this.picBox2.TabStop = false;
            // 
            // gbOutputQR
            // 
            this.gbOutputQR.Controls.Add(this.picBox1);
            this.gbOutputQR.Location = new System.Drawing.Point(15, 181);
            this.gbOutputQR.Name = "gbOutputQR";
            this.gbOutputQR.Size = new System.Drawing.Size(253, 253);
            this.gbOutputQR.TabIndex = 10;
            this.gbOutputQR.TabStop = false;
            this.gbOutputQR.Text = "二维码";
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(7, 20);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(240, 227);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "二维码内容";
            // 
            // txtQRInput
            // 
            this.txtQRInput.Location = new System.Drawing.Point(97, 124);
            this.txtQRInput.Name = "txtQRInput";
            this.txtQRInput.Size = new System.Drawing.Size(296, 21);
            this.txtQRInput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbErrorCorrection);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbQRVersion);
            this.groupBox1.Controls.Add(this.cbEndoeMode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "二维码生成选项";
            // 
            // cbErrorCorrection
            // 
            this.cbErrorCorrection.FormattingEnabled = true;
            this.cbErrorCorrection.Location = new System.Drawing.Point(71, 20);
            this.cbErrorCorrection.Name = "cbErrorCorrection";
            this.cbErrorCorrection.Size = new System.Drawing.Size(71, 20);
            this.cbErrorCorrection.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "加密版本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "修正比例";
            // 
            // cbQRVersion
            // 
            this.cbQRVersion.FormattingEnabled = true;
            this.cbQRVersion.Location = new System.Drawing.Point(272, 59);
            this.cbQRVersion.Name = "cbQRVersion";
            this.cbQRVersion.Size = new System.Drawing.Size(71, 20);
            this.cbQRVersion.TabIndex = 5;
            // 
            // cbEndoeMode
            // 
            this.cbEndoeMode.FormattingEnabled = true;
            this.cbEndoeMode.Location = new System.Drawing.Point(272, 20);
            this.cbEndoeMode.Name = "cbEndoeMode";
            this.cbEndoeMode.Size = new System.Drawing.Size(71, 20);
            this.cbEndoeMode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "加密方法";
            // 
            // btnGenerateQR
            // 
            this.btnGenerateQR.Location = new System.Drawing.Point(6, 440);
            this.btnGenerateQR.Name = "btnGenerateQR";
            this.btnGenerateQR.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateQR.TabIndex = 0;
            this.btnGenerateQR.Text = "生成二维码";
            this.btnGenerateQR.UseVisualStyleBackColor = true;
            this.btnGenerateQR.Click += new System.EventHandler(this.btnGenerateQR_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbQRDecodeOutput);
            this.tabPage2.Controls.Add(this.btnClipboard);
            this.tabPage2.Controls.Add(this.lbDecodeQR);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnChooseQR);
            this.tabPage2.Controls.Add(this.btnDecodeQR);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 474);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "解释二维码";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbDecodeQR
            // 
            this.lbDecodeQR.AutoSize = true;
            this.lbDecodeQR.Location = new System.Drawing.Point(32, 395);
            this.lbDecodeQR.Name = "lbDecodeQR";
            this.lbDecodeQR.Size = new System.Drawing.Size(65, 12);
            this.lbDecodeQR.TabIndex = 3;
            this.lbDecodeQR.Text = "解释内容: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picBox3);
            this.groupBox2.Location = new System.Drawing.Point(25, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 310);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "二维码";
            // 
            // picBox3
            // 
            this.picBox3.Location = new System.Drawing.Point(22, 28);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(260, 260);
            this.picBox3.TabIndex = 0;
            this.picBox3.TabStop = false;
            // 
            // btnChooseQR
            // 
            this.btnChooseQR.Location = new System.Drawing.Point(25, 34);
            this.btnChooseQR.Name = "btnChooseQR";
            this.btnChooseQR.Size = new System.Drawing.Size(159, 23);
            this.btnChooseQR.TabIndex = 1;
            this.btnChooseQR.Text = "选择要解析的二维码图片";
            this.btnChooseQR.UseVisualStyleBackColor = true;
            this.btnChooseQR.Click += new System.EventHandler(this.btnChooseQR_Click);
            // 
            // btnDecodeQR
            // 
            this.btnDecodeQR.Location = new System.Drawing.Point(3, 433);
            this.btnDecodeQR.Name = "btnDecodeQR";
            this.btnDecodeQR.Size = new System.Drawing.Size(75, 23);
            this.btnDecodeQR.TabIndex = 0;
            this.btnDecodeQR.Text = "解释二维码";
            this.btnDecodeQR.UseVisualStyleBackColor = true;
            this.btnDecodeQR.Click += new System.EventHandler(this.btnDecodeQR_Click);
            // 
            // btnClipboard
            // 
            this.btnClipboard.Location = new System.Drawing.Point(292, 433);
            this.btnClipboard.Name = "btnClipboard";
            this.btnClipboard.Size = new System.Drawing.Size(92, 23);
            this.btnClipboard.TabIndex = 4;
            this.btnClipboard.Text = "复制到剪贴板";
            this.btnClipboard.UseVisualStyleBackColor = true;
            this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
            // 
            // lbQRDecodeOutput
            // 
            this.lbQRDecodeOutput.AutoSize = true;
            this.lbQRDecodeOutput.Location = new System.Drawing.Point(91, 395);
            this.lbQRDecodeOutput.Name = "lbQRDecodeOutput";
            this.lbQRDecodeOutput.Size = new System.Drawing.Size(0, 12);
            this.lbQRDecodeOutput.TabIndex = 5;
            // 
            // QREncode_Decode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 524);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QREncode_Decode";
            this.Text = "QR二维码生成和解释工具";
            this.Load += new System.EventHandler(this.QREncode_Decode_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb2InsertLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.gbOutputQR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
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
        private System.Windows.Forms.Label lbDecodeQR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Button btnClipboard;
        private System.Windows.Forms.Label lbQRDecodeOutput;
    }
}