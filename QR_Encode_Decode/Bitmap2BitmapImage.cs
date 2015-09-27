using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows;
namespace QR_Encode_Decode
{
    class Bitmap2BitmapImage
    {
        private Bitmap bmp;
         public void set(object o)
        {
            if (o != null)
            {
                bmp = o as Bitmap;
            } else
            {
                bmp = new Bitmap(100, 100);
            }
           

        }

        public BitmapImage Bitmap2BitmapImage_()
        {
            if (bmp != null)
            {
                BitmapSource i = Imaging.CreateBitmapSourceFromHBitmap(
                             bmp.GetHbitmap(),
                             IntPtr.Zero,
                             System.Windows.Int32Rect.Empty,
                             BitmapSizeOptions.FromEmptyOptions());
                return (BitmapImage)i;
            } else
            {
                BitmapImage bmpi = new BitmapImage();
                return bmpi;
            }
        }
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject); //用于加载系统函数


        public BitmapImage Bitmap2BitmapImage_(Bitmap bitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bitmap.Save(ms, bitmap.RawFormat);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
            }

            return bitmapImage;
        }


        public  ImageSource ChangeBitmapToImageSource(Bitmap bitmap)
        {
            //Bitmap bitmap = icon.ToBitmap();
            IntPtr hBitmap = bitmap.GetHbitmap();
            ImageSource wpfBitmap = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                hBitmap,
                IntPtr.Zero,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            if (!DeleteObject(hBitmap))
            {
                throw new System.ComponentModel.Win32Exception();
            }
            return wpfBitmap;
        }

    }
}
