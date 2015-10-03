using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;
using System.Drawing;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode;
using System.Windows.Interop;

namespace QR_Encode_Decode
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Bitmap QRLogo;
        private Bitmap QR_Create()
        {
            Bitmap bmi;
            //object Obmp;
           
            Encoding encode = Encoding.UTF8;

          
            if (textBox1.Text == string.Empty) //如果没有输入生成二维码的内容，即为抛出异常
            {
                throw new Exception("请输入要生成二维码的内容");
            }

            string encodeStr = textBox1.Text.ToString();

            QRCodeEncoder qrEncode = new QRCodeEncoder();
           // BitmapHelper bmp2bmpimg = new BitmapHelper();

            qrEncode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//GetEncodeMode(cbEndoeMode.SelectedItem); //选择压缩的方式
            qrEncode.QRCodeScale = 4;//GetQRSize(cbQRSize.SelectedItem);
            qrEncode.QRCodeVersion = 7;//GetQRVersion(cbQRVersion.SelectedItem);   //选择QR版本
            qrEncode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//GetErrorCorrection(cbErrorCorrection.SelectedItem);  //选择修正率
              bmi = qrEncode.Encode(encodeStr, encode); //生成二维码，并保存到img 类当中

            // BitmapImage bmi = Obmp as BitmapImage;


            return bmi != null ? bmi : new Bitmap(100, 100);
        }

        private void GeneraQR_Click(object sender, EventArgs e) //此用于生成二维码使用
        {

            try {
                ImageSource img;
                Bitmap logo = QRLogo;
                Bitmap QRBitmap;
                BitmapHelper bitmaphelper = new BitmapHelper();
                int LogoSize = textBox1.Text != "" ?  Convert.ToInt32(textBox2.Text.ToString()) : 0;

                QRBitmap = QR_Create();


                if (logo != null && QRBitmap != null)
                {
                    NeedResize_ need = new NeedResize_
                    {
                        Need = true,
                        Width = LogoSize,
                        Height = LogoSize
                    };

                    QRBitmap = bitmaphelper.WriteLogo2QRImage(QRBitmap, logo, need); //将logo置入到QR里面

                    img = bitmaphelper.Bitmap2ImageSource(QRBitmap);
                }
                else
                {


                    img = bitmaphelper.Bitmap2ImageSource(QRBitmap);
                }

                image.Source = img;

            } 
            catch (Exception es) //用于捕捉所有出错的异常
            {
                MessageBox.Show(es.Message.ToString(),"程序异常",MessageBoxButton.OK,MessageBoxImage.Error);
            }   

        }

        private void SelQRLogo_Click(object sender, EventArgs e) //用于获取二维码的logo图标
        {
           QRLogo = GetLogoFile();
        }

        private Bitmap GetLogoFile()
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new OpenFileDialog();//文件打开对话框      
            openFileDialog.Filter = "JPEG|*.jpeg;*.jpg|位图文件|*.bmp|PNG|*.png|所有文件|*.*";//只能打开我们设置的这几类文件 
            if (openFileDialog.ShowDialog() == true)
            {
                string fileName = openFileDialog.FileName;
                BitmapHelper bitmap2ImageSorce = new BitmapHelper();

                int picheight = (int)image1.Height;
                int picwidth = (int)image1.Width;
                System.Drawing.Bitmap newBmp = new Bitmap(fileName);
                Bitmap bmp = new Bitmap(newBmp, picwidth, picheight);
                image1.Source = bitmap2ImageSorce.Bitmap2ImageSource(bmp);

                return bmp != null ? bmp : new Bitmap(100, 100);
            }
            return new Bitmap(100, 100);
        }
    }
}
