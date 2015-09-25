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


namespace QR_Encode_Decode
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

       // private object QRContactImage; //用于生成二维码联系人
        private object QRContactlogoImg; //用于获取联系人自定义图标
        
        //QRCodeEncoder QRencode; //二维码生成 
       // int LogoSize; //定义logo的大小 ，默认大小为 30;

        private float X;

        private float Y;

        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
                if (con.Controls.Count > 0)
                    setTag(con);
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            foreach (Control con in cons.Controls)
            {

                string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * newx;
                con.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * newy;
                con.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * newx;
                con.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * newy;
                con.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * Math.Min(newx, newy);
                con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                if (con.Controls.Count > 0)
                {
                    setControls(newx, newy, con);
                }
            }

        }

        void QR_Encode_Decode_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / X;
            float newy = this.Height / Y;
            setControls(newx, newy, this);
            //this.Text = this.Width.ToString() + " " + this.Height.ToString();

        }

 

        private void QREncode_Decode_Load(object sender, EventArgs e)
        {
            //用于定义窗口的自动变化
            this.Resize += new EventHandler(QR_Encode_Decode_Resize);
            X = this.Width;
            Y = this.Height;

            setTag(this);
            InitQRCombox();
            btnSaveQR.Enabled = false;

            rbOptModNormal.Checked = true; //默认设置为一般模式

            //LogoSize = 30; 
            txtSizeOfLogo.Text = "30"; //初始大小为30 
            txtContactLogoSize.Text = "30"; //初始大小为30

           // this.MinimumSize = new Size(609, 676);
           // this.MaximumSize = new Size(800, 900);
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
                int item = i;
                cbQRVersion.Items.Add(item);
            }
            cbQRVersion.SelectedIndex = 6;


            //设置二维码的显示尺寸
            //从4 - 10
            //目前只设置7个尺寸
            for (int j = 4; j <= 10; j++)
            {
                int QRSize = j;
                cbQRSize.Items.Add(QRSize);
            }
            cbQRSize.SelectedIndex = 0; //默认选择为 4
            
        }


        //根据选项，获取当前的压缩格式
        private QRCodeEncoder.ENCODE_MODE GetEncodeMode(object encodemode)
        {
            QRCodeEncoder.ENCODE_MODE QREcodeMode;
            string ecm = encodemode as string;
            switch (ecm)
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
        private QRCodeEncoder.ERROR_CORRECTION GetErrorCorrection(object errCorrection)
        {
            QRCodeEncoder.ERROR_CORRECTION QRErrCorrection;
            string ec = errCorrection as string;
            switch (ec)
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

        private int GetQRVersion(object QRVersionStr)
        {
            int qrversion = 1;
            qrversion = (int)QRVersionStr;
            return qrversion;
        }

        private int GetQRSize(object QRSizeStr)
        {
            int qrsize = 4;
            qrsize = (int)QRSizeStr;
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
                qrEncode.QRCodeEncodeMode = GetEncodeMode(cbEndoeMode.SelectedItem); //选择压缩的方式
                qrEncode.QRCodeScale = GetQRSize(cbQRSize.SelectedItem);
                qrEncode.QRCodeVersion = GetQRVersion(cbQRVersion.SelectedItem);   //选择QR版本
                qrEncode.QRCodeErrorCorrect = GetErrorCorrection(cbErrorCorrection.SelectedItem);  //选择修正率
                img = qrEncode.Encode(encodeStr, encode); //生成二维码，并保存到img 类当中
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

            QRCodeEncoder QRencode = null; //二维码生成 
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
                //坐标点是 （x/2 - logosize/2,y/2 - logosize/2)
                //Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                Point point = new Point(X / 2 - logosize / 2, Y / 2 - logosize / 2); 
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

        private object GetLogoFile(PictureBox pic)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|所有文件|PNG|*.png|*.*";//只能打开我们设置的这几类文件 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                int picheight = pic.Height;
                int picwidth = pic.Width;
                Bitmap newBmp = new Bitmap(fileName);
                object img;
                Bitmap bmp = new Bitmap(newBmp, picwidth, picheight);
                pic.Image = bmp;
                img = bmp;
                return img;
            }
            return new Bitmap(100, 100);
        }

        private void btnInsertLogo_Click(object sender, EventArgs e)
        {
           logoImage =  GetLogoFile(picBox2);
        }


        //-------------------------- 解释二维码 --------------------
     
        //选择要进行解析的二维码图片
        private void btnChooseQR_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|PNG|*.png|所有文件|*.*";//只能打开我们设置的这几类文件 
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
        #region 生成二维码联系人
        //把输入的内容,变成vCard格式的字符串
        private string GetContactstr()
        {
            string str;
            str = string.Format("BEGIN:VCARD\n" +
                               "VERSION:3.0\n" +
                               "N:{0}\n" +
                                "EMAIL:{1}\n" +
                                "TEL:{2}\n" +
                                "TEL;CELL:{3}\n" +
                                "ADR:{4}\n" +
                                "ORG:{5}\n" +
                                "TITLE:{6}\n" +
                                "URL:{7}" +
                                "NOTE:{8}\n" +
                                "END:VCARD",txtContactName.Text,txtContactMailBox.Text,txtContactTel.Text,txtContactTELCell.Text,
                                txtContactADD.Text,txtContactORG.Text,txtContactTitle.Text,txtContactURL.Text,txtContactNote.Text);

            return str;

        }
        private void btnContactChooseLogo_Click(object sender, EventArgs e)
        {
            QRContactlogoImg = GetLogoFile(picBoxContactLogo); //获取logo图片
        }

        private void CreateQRContactbmp()
        {
            string encodestr = GetContactstr();
            try
            {
                //判断是否已经输入了要生成二维码的内容 
                if (string.IsNullOrEmpty(encodestr) == true)
                {
                    throw new Exception("请输入要生成二维码的内容");
                }
                Encoding en = Encoding.UTF8;
                Bitmap ContactImg;
                QRCodeEncoder qrencode = new QRCodeEncoder();
                qrencode = new QRCodeEncoder();
                qrencode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE; //选择压缩的方式
                qrencode.QRCodeScale = 4;
                qrencode.QRCodeVersion = 25;   //选择QR版本
                qrencode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;  //选择修正率,最高比率30%
                ContactImg = qrencode.Encode(encodestr, en); //生成二维码，并保存到img 类当中

                Bitmap ResizeQRImg;
                //当生成的二维码大于图片窗口时， 重新修改二维码的尺寸以适应窗口大小
                if (ContactImg.Width > picContactImg.Width)
                {
                    ResizeQRImg = new Bitmap(ContactImg, picContactImg.Width, picContactImg.Height);
                }
                else
                {
                    //当二维码的尺寸小于窗口，以居中显示
                    ResizeQRImg = new Bitmap(ContactImg);
                    picContactImg.SizeMode = PictureBoxSizeMode.CenterImage;

                }

                picContactImg.Image = ResizeQRImg;


                if (QRContactlogoImg == null)
                {
                    //picBox1.Image = ResizeQRImg;
                    picContactImg.Image = ResizeQRImg;

                }
                else
                {
                    Bitmap bLogo = QRContactlogoImg as Bitmap; //获取logo图片对象 
                    //bLogo = new Bitmap(bLogo, 30, 30); //改变图片的大小这里我们设置为30   
                    int logosize = GetSizeOfLogo(txtContactLogoSize.Text);
                    bLogo = new Bitmap(bLogo, logosize, logosize);
                    int Y = ResizeQRImg.Height;
                    int X = ResizeQRImg.Width;
                    //坐标点是 （x/2 - logosize/2,y/2 - logosize/2)
                    //Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
                    Point point = new Point(X / 2 - logosize / 2, Y / 2 - logosize / 2);
                    Graphics g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
                    g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    

                    picContactImg.Image = ResizeQRImg;
                }



            }
            catch (IndexOutOfRangeException ioRe)
            {
                MessageBox.Show(ioRe.Message, "请选择高一些的 二维码版本");


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "系统提示");

            }
        }

        private void btnCreateContactQR_Click(object sender, EventArgs e) //用于生成二维码联系人
        {
            CreateQRContactbmp();
        }

        private void btnSaveQRContact_Click(object sender, EventArgs e) //用于保存二维码图片到本地
        {
            SaveFileDialog saveFile = new SaveFileDialog();//创建保存对话框 
            saveFile.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|PNG|*.png|所有文件|*.*";//设置保存的图片格式  
            if ( picContactImg.Image!= null)
            {
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    string sFilePathName = saveFile.FileName;
                    Image img = picContactImg.Image;
                    img.Save(sFilePathName);
                }
            }
            else
            {
                MessageBox.Show("请先 生成二维码图片", "系统提示");
            }  
        }
        #endregion

        #region 版本说明
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此程序由江门振业水产杨万荣创建\n版权归杨万荣所有\n","二维码生成和解释工具");
        }

        #endregion


    }
}
