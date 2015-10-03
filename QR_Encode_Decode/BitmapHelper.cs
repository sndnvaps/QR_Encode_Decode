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
    #region 定义结构体，用于确认图片是否需要修改其尺寸
    struct NeedResize_
    {
        Boolean need;
        int width;
        int height;

        //是否需要修改图片的大小，true or false
        public Boolean Need
        {
            get
            {
                return need;
            }
            set
            {
                need = value;
            }
        }

        //设置宽度

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        //设置高度
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

    }
    #endregion

    class BitmapHelper
    {
       // private Bitmap bmp;

        #region 定义 BitmapHelper类，用于处理bitmap 类型图片
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject); //用于加载系统函数

        //将bitmap 格式转换为 imagesource 
        public  ImageSource Bitmap2ImageSource(Bitmap bitmap)
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


        //在将bitmap转换成ImageSource 的时候，也要修改图片的尺寸 
        //NeedResize_ 是一个结构体 
        //struct NeedResize_ {
        // bool need; 是否需要修改图片的尺寸 
        // int width; 修改图片的宽 
        //int height; 修改图片的高
        //} 
        
        //bitmap 是要修改的原始图片 
                
        public ImageSource Bitmap2ImageSource(Bitmap bitmap,NeedResize_ need)
        {
            if (need.Need == false && need.Width == 0&& need.Height == 0) //不需要修改图片的大小
            {
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
            } else if (need.Need == true && need.Width > 0 && need.Height > 0 ) //
            {
                int width = need.Width;
                int height = need.Height;
                Bitmap nbmp = Resize(bitmap,width,height);
                ImageSource wpfbitmap =  Bitmap2ImageSource(nbmp);

                return wpfbitmap;             
            } else
            {
                throw new ArgumentException("需要修改的图片的尺寸出错或者指定的图片不存在!"); //否则抛出参数异常
            }
        }


        //此函数用于修改图片的尺寸
        //para = bmp -> 原始图片
        //para nwidth -> 需要修改为的宽度
        //para nwidth -> 需要修改为的高度
        public Bitmap Resize( Bitmap bmp, int nwidth,int nheight)
        {
            if (bmp != null && nwidth > 0 && nheight > 0) //当三个参数都不为空时，修改图片的尺寸
            {
                Bitmap nbmp = new Bitmap(bmp, nwidth
                    , nheight);
                return (nbmp != null ? nbmp : new Bitmap(100, 100));
            } else
            {
                throw new ArgumentException("需要修改的图片的尺寸出错或者指定的图片不存在!"); //否则抛出参数异常
            }
        }

        //将logo 画到二维码上 
        //Writelogo2QRImage 
        //paralist 
        //bitmap1 -> 此为二维码原图
        //bitmap2 -> logo 图片 
        //NeedResize_ -> 定义要修改图片的尺寸 
        public Bitmap WriteLogo2QRImage(Bitmap bmpQR,Bitmap bmpLogo,NeedResize_ need)
        {

            Bitmap bLogo =bmpLogo; //获取logo图片对象 
            Bitmap ResizeQRImg = bmpQR;

             if (need.Need == false)
            {
                throw new ArgumentException("NeedResize.Need 选项必须要为 true 才可以设置logo的大小");
            }

            bLogo = new Bitmap(bLogo, need.Width, need.Height);
             
            //获取二维码图片的大小尺寸
            int Y = bmpQR.Height;
            int X = bmpQR.Width;



            //坐标点是 （x/2 - logosize/2,y/2 - logosize/2)
            //Point point = new Point(X / 2 - 15, Y / 2 - 15);//logo图片绘制到二维码上，这里将简单计算一下logo所在的坐标 
            System.Drawing.Point point = new System.Drawing.Point(X / 2 - need.Width / 2, Y / 2 - need.Height / 2);
            Graphics g = Graphics.FromImage(ResizeQRImg);//创建一个画布           
            g.DrawImage(bLogo, point);//将logo图片绘制到二维码图片上    

            return ResizeQRImg;


        }

        #endregion
    }
}
