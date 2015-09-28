using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private ImageSource QR_Create()
        {
            //BitmapImage bmi;
            //object Obmp;
            ImageSource ims;
            
            Encoding encode = Encoding.UTF8;

          
            if (textBox1.Text == string.Empty) //如果没有输入生成二维码的内容，即为抛出异常
            {
                throw new Exception("请输入要生成二维码的内容");
            }

            string encodeStr = textBox1.Text.ToString();

            QRCodeEncoder qrEncode = new QRCodeEncoder();
            Bitmap2BitmapImage bmp2bmpimg = new Bitmap2BitmapImage();

            qrEncode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;//GetEncodeMode(cbEndoeMode.SelectedItem); //选择压缩的方式
            qrEncode.QRCodeScale = 4;//GetQRSize(cbQRSize.SelectedItem);
            qrEncode.QRCodeVersion = 7;//GetQRVersion(cbQRVersion.SelectedItem);   //选择QR版本
            qrEncode.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;//GetErrorCorrection(cbErrorCorrection.SelectedItem);  //选择修正率
            ims = bmp2bmpimg.ChangeBitmapToImageSource (qrEncode.Encode(encodeStr, encode)); //生成二维码，并保存到img 类当中

           // BitmapImage bmi = Obmp as BitmapImage;


            return ims;
        }

        private void GeneraQR_Click(object sender, RoutedEventArgs e) //此用于生成二维码使用
        {

            try {
                ImageSource img;
                img = QR_Create();
                image.Source = img;

            } 
            catch (Exception es) //用于捕捉所有出错的异常
            {
                MessageBox.Show(es.Message.ToString(),"程序异常",MessageBoxButton.OK,MessageBoxImage.Error);
            }      

        }
    }
}
