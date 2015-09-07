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
using ThoughtWorks.QRCode;


namespace QR_C_Sharp_Test
{
    public partial class QREncode_Decode : Form
    {
        public QREncode_Decode()
        {
            InitializeComponent();
        }
        private object logoImage;
        private object DecodeImage;
        private void QREncode_Decode_Load(object sender, EventArgs e)
        {
            InitQRCombox();
            btnSaveQR.Enabled = false;
        }

        private void InitQRCombox()
        {
            //初始化修正比例 
            
            cbErrorCorrection.Items.Add("7%"); //7% -> L
            cbErrorCorrection.Items.Add("15%"); //15% -> M
            cbErrorCorrection.Items.Add("25%"); //25% -> Q
            cbErrorCorrection.Items.Add("30%"); //30% -> H
            cbErrorCorrection.SelectedIndex = 1;
            //end 

            //初始化 初始化压缩方式
            cbEndoeMode.Items.Add("ALPHA_NUMERIC");
            cbEndoeMode.Items.Add("BYTE");
            cbEndoeMode.Items.Add("NUMERIC");
            cbEndoeMode.SelectedIndex = 1;

            //初始化版本号 
            // (V-1)*4 + 21
            //共有40个版本号, 
            // v1 - v40 
            for (int i = 1; i <= 40; i++) {
                string QRVersionCode = i.ToString();
                cbQRVersion.Items.Add(QRVersionCode);
            }
            cbQRVersion.SelectedIndex = 6;
            
        }
        //根据选项，获取当前的压缩格式
        private QRCodeEncoder.ENCODE_MODE GetEncodeMode(string encodemode)
        {
            QRCodeEncoder.ENCODE_MODE QREcodeMode;
            switch (encodemode)
            {
                case "ALPHA_NUMERIC": QREcodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;
                    break;
                case "BYTE": QREcodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;
                case "NUMERIC": QREcodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;
                    break;
                default: QREcodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                    break;

            }
            return QREcodeMode;
        }

        //根据选项，获取当前的修正比例
        private QRCodeEncoder.ERROR_CORRECTION GetErrorCorrection(string errCorrection)
        {
            QRCodeEncoder.ERROR_CORRECTION QRErrCorrection;
            switch (errCorrection)
            {
                case "7%": QRErrCorrection = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "15%": QRErrCorrection = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
                case "25%": QRErrCorrection = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
                case "30%": QRErrCorrection = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
                default: QRErrCorrection = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
            }
            return QRErrCorrection;
        }

        private int GetQRVersion(string QRVersionStr)
        {
            int qrversion = 1;
            qrversion = Convert.ToInt32(QRVersionStr);
            return qrversion;
        }

        private Bitmap GenerateCode()
        {
            string qrstr = txtQRInput.Text.ToString();
            QRCodeEncoder qrencode = new QRCodeEncoder();
            qrencode.QRCodeEncodeMode = GetEncodeMode(cbEndoeMode.Text.ToString());
            qrencode.QRCodeScale = 4;
            qrencode.QRCodeVersion = GetQRVersion(cbQRVersion.Text.ToString());
            qrencode.QRCodeErrorCorrect = GetErrorCorrection(cbErrorCorrection.Text.ToString());

            Bitmap img = qrencode.Encode(qrstr, Encoding.UTF8);
            return img;
            
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQRInput.Text))
            {
                MessageBox.Show("请输入要生成二维码的内容","系统提示");
            }
            Bitmap QRImg = GenerateCode();
            Bitmap ResizeQRImg;
            //当生成的二维码大于图片窗口时， 重新修改二维码的尺寸以适应窗口大小
            if (QRImg.Width > picBox1.Width)
            {
                ResizeQRImg = new Bitmap(QRImg, picBox1.Width, picBox1.Height);
            }
            else
            {
                //当二维码的尺寸小于窗口，以居中显示
                ResizeQRImg = new Bitmap(QRImg);
                picBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            }

            if (logoImage == null)
            {
                picBox1.Image = ResizeQRImg;
               
            }
            else
            {
                Bitmap bLogo = logoImage as Bitmap; //获取logo图片对象 
                bLogo = new Bitmap(bLogo, 30, 30); //改变图片的大小这里我们设置为30      
                int Y = ResizeQRImg.Height;
                int X = ResizeQRImg.Width;
                Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                Graphics g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
                g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    

                picBox1.Image = ResizeQRImg;         
            }

            btnSaveQR.Enabled = true;
        }


        private void btnSaveQR_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();//创建保存对话框 
            saveFile.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|*.*";//设置保存的图片格式  
            if (picBox1.Image != null)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string sFilePathName = saveFile.FileName;
                    Image img = picBox1.Image;
                    img.Save(sFilePathName);
                }
            }
            else
            {
                MessageBox.Show("请先生成二维码图片","系统提示");
            }  
        }

      

        private void btnInsertLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|*.*";//只能打开我们设置的这几类文件 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                int picheight = picBox2.Height;
                int picwidth = picBox2.Width;
                Bitmap newBmp = new Bitmap(fileName);
                Bitmap bmp = new Bitmap(newBmp,picwidth,picheight);
                picBox2.Image = bmp;
                logoImage = bmp;
            }
        }

        //-------------------------- 解释二维码 --------------------
     
        //选择要进行解析的二维码图片
        private void btnChooseQR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|*.*";//只能打开我们设置的这几类文件 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                int picheight = picBox3.Height;
                int picwidth = picBox3.Width;
                Bitmap bmp;

                Bitmap newBmp = new Bitmap(fileName);
                if (newBmp.Width > picBox3.Width)
                {
                     bmp = new Bitmap(newBmp, picwidth, picheight);
                     
                }
                else
                {
                    bmp = new Bitmap(newBmp);
                    picBox3.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                
                picBox3.Image = bmp;
                
                DecodeImage =  bmp;
            }
        }

        private void btnDecodeQR_Click(object sender, EventArgs e)
        {
            if (picBox3.Image == null)
            {
                MessageBox.Show("请选择要解析的二维码图片", "系统提示");
            }
            else
            {
                QRCodeDecoder qrDecode = new QRCodeDecoder();
                //qrDecode.decode()
                Bitmap decodeimage = DecodeImage as Bitmap;
                Bitmap bmp = new Bitmap(decodeimage, picBox3.Width, picBox3.Height);
                ThoughtWorks.QRCode.Codec.Data.QRCodeImage qrimage = new ThoughtWorks.QRCode.Codec.Data.QRCodeBitmapImage(bmp);
                lbQRDecodeOutput.Text =  qrDecode.decode(qrimage, Encoding.UTF8);



            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            string Copy2Clipboard = lbQRDecodeOutput.Text;
            //string message = string.Format("复制:{0} 到剪贴板成功", Copy2Clipboard);
            Clipboard.SetText(lbQRDecodeOutput.Text);
            MessageBox.Show("复制成功!", "系统提示");
        }

        
    }
}
