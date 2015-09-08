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
        private object logoImage;  //用于加载 自定义LOGO
        private object DecodeImage; //用于加载 解析图片
        private object QRImage; //用于保存生成的二维码图片
        QRCodeEncoder QRencode; //二维码生成 
       // int LogoSize; //定义logo的大小 ，默认大小为 30;
        private void QREncode_Decode_Load(object sender, EventArgs e)
        {
            InitQRCombox();
            btnSaveQR.Enabled = false;

            rbOptModNormal.Checked = true; //默认设置为一般模式

            //LogoSize = 30; 
            txtSizeOfLogo.Text = "30"; //初始大小为30 

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


            //设置二维码的显示尺寸
            //从4 - 10
            //目前只设置7个尺寸
            for (int j = 4; j <= 10; j++)
            {
                string QRSize = j.ToString();
                cbQRSize.Items.Add(QRSize);
            }
            cbQRSize.SelectedIndex = 0; //默认选择为 4
            
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

        private int GetQRSize(string QRSizeStr)
        {
            int qrsize = 4;
            qrsize = Convert.ToInt32(QRSizeStr);
            return qrsize;
        }
        private int GetSizeOfLogo(string QRLogoSize)
        {
             int LogoSize = 30;
            LogoSize = Convert.ToInt32(QRLogoSize);
            return LogoSize;
        }

        private void GenerateQRCodeBitmap( out object img, QRCodeEncoder qrEncode, string encodeStr, Encoding encode)
        {
           
            try
            {
                //判断是否已经输入了要生成二维码的内容 
                if (string.IsNullOrEmpty(encodeStr) == true)
                {
                    throw new Exception("请输入要生成二维码的内容");
                }

                qrEncode = new QRCodeEncoder();
                qrEncode.QRCodeEncodeMode = GetEncodeMode(cbEndoeMode.Text.ToString());
                qrEncode.QRCodeScale = GetQRSize(cbQRSize.Text.ToString());
                qrEncode.QRCodeVersion = GetQRVersion(cbQRVersion.Text.ToString());
                qrEncode.QRCodeErrorCorrect = GetErrorCorrection(cbErrorCorrection.Text.ToString());

                img = qrEncode.Encode(encodeStr, Encoding.UTF8); //生成二维码，并保存到img 类当中
            }
            catch (IndexOutOfRangeException ioRe)
           {
               MessageBox.Show(ioRe.Message,"请选择高一些的 二维码版本");
               img = new Bitmap(100, 100);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"系统提示");
                img = new Bitmap(100, 100);
            }
        }

        private void WriteLogo2QRBitmap() 
        {


            //生成二维码，并保存到 object QRImage 当中
            GenerateQRCodeBitmap(out QRImage, QRencode, txtQRInput.Text.ToString(), Encoding.UTF8);

            int logosize = GetSizeOfLogo(txtSizeOfLogo.Text.ToString());

            Bitmap QRImg = QRImage as Bitmap; //取出数据，并保存到QRImage 当中

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
                //bLogo = new Bitmap(bLogo, 30, 30); //改变图片的大小这里我们设置为30   
                bLogo = new Bitmap(bLogo, logosize, logosize);
                int Y = ResizeQRImg.Height;
                int X = ResizeQRImg.Width;
                Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                Graphics g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
                g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    

                picBox1.Image = ResizeQRImg;
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {

            WriteLogo2QRBitmap();
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
                //获取出错 Exception 
                try
                {
                    QRCodeDecoder qrDecode = new QRCodeDecoder();
                    //qrDecode.decode()
                    Bitmap decodeimage = DecodeImage as Bitmap;
                    Bitmap bmp = new Bitmap(decodeimage, picBox3.Width, picBox3.Height);
                    ThoughtWorks.QRCode.Codec.Data.QRCodeImage qrimage = new ThoughtWorks.QRCode.Codec.Data.QRCodeBitmapImage(bmp);
                    lbQRDecodeOutput.Text = qrDecode.decode(qrimage, Encoding.UTF8);
                }
                catch (ThoughtWorks.QRCode.ExceptionHandler.DecodingFailedException dfE)
                {
                    MessageBox.Show(dfE.Message); //显示解析二维码出错的原因
                }


            }
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            string Copy2Clipboard = lbQRDecodeOutput.Text;
            //string message = string.Format("复制:{0} 到剪贴板成功", Copy2Clipboard);
            Clipboard.SetText(lbQRDecodeOutput.Text);
            MessageBox.Show("复制成功!", "系统提示");
        }

        private void gbOptModeChoose_Enter(object sender, EventArgs e)
        {
           
        }

        private void rbOptModPro_CheckedChanged(object sender, EventArgs e)
        {
            cbEndoeMode.Enabled = true;
            cbErrorCorrection.Enabled = true;
            cbQRVersion.Enabled = true;
            cbQRSize.Enabled = true;
            txtSizeOfLogo.Enabled = true;
        }

        private void rbOptModNormal_CheckedChanged(object sender, EventArgs e)
        {
            cbEndoeMode.Enabled = false;
            cbErrorCorrection.Enabled = false;
            cbQRVersion.Enabled = false;
            cbQRSize.Enabled = false;
            txtSizeOfLogo.Enabled = false;
        }

        
    }
}
