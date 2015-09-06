using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ThoughtWorks.QRCode.Codec;
using System.IO;
using System.Drawing.Imaging;

namespace QR_C_Sharp_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //错误修正比例 
            cbQRLevel.Items.Add("H");
            cbQRLevel.Items.Add("L");
            cbQRLevel.Items.Add("M");
            cbQRLevel.Items.Add("Q");
            this.cbQRLevel.SelectedIndex = 0;
            //-----------------------------
            cbEncodeMode.Items.Add("ALPHA_NUMERIC");
            cbEncodeMode.Items.Add("BYTE");
            cbEncodeMode.Items.Add("NUMERIC");
            this.cbEncodeMode.SelectedIndex = 1; //默认选项为 BYTE
            btnQRSave.Enabled = false;

           //QRCodeEncoder.ENCODE_MODE.NUMERIC
           // QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;

            //cbQRLevel.Text.Equals("M");
        }


        private object logoImage; // 二维码 logo图片

        private QRCodeEncoder.ERROR_CORRECTION EQRLevel_(string error_correction)
        {
            QRCodeEncoder.ERROR_CORRECTION Error_Correction;
            switch (error_correction)
            {
                case "H": Error_Correction = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
                case "L": Error_Correction = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "M": Error_Correction = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
                case "Q": Error_Correction = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
                default : Error_Correction = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
            }
            return Error_Correction;
        }


        private QRCodeEncoder.ENCODE_MODE EQREncode_Mode(string sEncodeMode)
        {
            QRCodeEncoder.ENCODE_MODE EEncodemode;
            switch (sEncodeMode)
            {
                case "ALPHA_NUMERIC": EEncodemode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    break;
                case "BYTE": EEncodemode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
                case "NUMERIC": EEncodemode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                    break;
                default:  EEncodemode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    break;
            }
            return EEncodemode;
        }

        public Bitmap GenerateQR(string writeStr, string QRlevel, string strEncodeMode)
        {
            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();
            qRCodeEncoder.QRCodeEncodeMode = EQREncode_Mode(strEncodeMode);//设置二维码编码格式 
            qRCodeEncoder.QRCodeScale = 4;//设置编码测量度             
            qRCodeEncoder.QRCodeVersion = 7;//设置编码版本   
            qRCodeEncoder.QRCodeErrorCorrect = EQRLevel_(QRlevel);//设置错误校验 
            //string temp = 
            Bitmap image = qRCodeEncoder.Encode(writeStr,Encoding.UTF8); //设置编码格式为 utf8
            return image; 
        }

        private void btnCreateQR_Click(object sender, EventArgs e)
        {
            Bitmap Barcode;
            if (string.IsNullOrEmpty(txtQRInputBox.Text))
            {
                MessageBox.Show("请输入要生成的内容");
            }
            Barcode = GenerateQR(txtQRInputBox.Text.ToString(), cbQRLevel.Text, cbEncodeMode.Text); //生成二维码图片

            pictureBox1.Size = new Size(250, 250);
            if (logoImage == null)
            {
                pictureBox1.Image = Barcode;
            }
            else
            {
                Bitmap bLogo = logoImage as Bitmap; //获取logo图片对象 
                bLogo = new Bitmap(bLogo, 30, 30); //改变图片的大小这里我们设置为30      
                int Y = Barcode.Height; 
                int X = Barcode.Width;
                Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                Graphics g = Graphics.FromImage(Barcode);//创建一个画布           
                g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    

                pictureBox1.Image = Barcode;                
            } 

            btnQRSave.Enabled = true;

           
    
                
        }

        private void btnQRSave_Click(object sender, EventArgs e)
        {
             SaveFileDialog saveFile = new SaveFileDialog();//创建保存对话框 
            saveFile.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|*.*";//设置保存的图片格式  
            if (pictureBox1.Image != null)             { 
                if (saveFile.ShowDialog() == DialogResult.OK)                 { 
                string sFilePathName = saveFile.FileName;  
                    Image img = pictureBox1.Image;                    
                    img.Save(sFilePathName);              
                }
            }
            else
            {
                MessageBox.Show("请先生成二维码图片");
            }       
             
        }

        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|*.*";//只能打开我们设置的这几类文件 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                Bitmap newBmp = new Bitmap(fileName);

                Bitmap bmp = new Bitmap(newBmp);
                pictureBox1.Image = bmp;
                logoImage = bmp;
            }
        }
     }
}

