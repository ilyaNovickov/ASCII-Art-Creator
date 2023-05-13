using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ASCIIArtWinFormsApp_dotNet_Framework_
{
    internal static class ImageChanger
    {
        public static Bitmap ResizePicture(Bitmap bitmap, int width)
        {
            int height = (int)(((float)width / (float)bitmap.Width) * (float)bitmap.Height);
            return new Bitmap(bitmap, new Size(width, height));
        }
        public static Bitmap ResizePicture(Bitmap bitmap, int width, int height)
        {
            if (height == 0)
                return ResizePicture(bitmap, width);
            return new Bitmap(bitmap, new Size(width, height));
        }
        public static Bitmap ResizePicture(Image bitmap, int width)
        {
            return ResizePicture((Bitmap)bitmap, width);
        }
        public static Bitmap ResizePicture(Image bitmap, int width, int height)
        { 
            return ResizePicture((Bitmap)bitmap, width, height);
        }

        public static Bitmap BlackAndWhiteCreator(Bitmap bitmap, bool invert = false)
        {
            Bitmap output = new Bitmap(bitmap.Width, bitmap.Height);
            for (int j = 0; j < bitmap.Height; j++)
                for (int i = 0; i < bitmap.Width; i++)
                {
                    UInt32 pixel = (UInt32)(bitmap.GetPixel(i, j).ToArgb());
                    float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                    float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                    float B = (float)(pixel & 0x000000FF);
                    R = G = B = (R + G + B) / 3.0f;
                    if (invert)
                        R = G = B = 255 - R;
                    UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
            return output;
        }
        public static Bitmap BlackAndWhiteCreator(Image bitmap, bool invert = false)
        {
            return BlackAndWhiteCreator((Bitmap)bitmap, invert);
        }
        public static Bitmap BlackAndWhiteCreator(Bitmap bitmap)
        {
            return BlackAndWhiteCreator(bitmap, false);
        }
        public static Bitmap BlackAndWhiteCreator(Image bitmap)
        {
            return BlackAndWhiteCreator((Bitmap)bitmap, false);
        }

        public static Bitmap GetMonochromeBitmap(Bitmap bitmap, bool invert = false)
        {
            Bitmap outputBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    byte monochromeColor = 0;
                    {
                        uint pixel = (uint)bitmap.GetPixel(x, y).ToArgb();
                        float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                        float G = (float)((pixel & 0x0000FF00) >> 8); // зеленый
                        float B = (float)(pixel & 0x000000FF);
                        R = G = B = (R + G + B) / 3.0f;
                        monochromeColor = R < (byte.MaxValue / 2) ? byte.MinValue : byte.MaxValue;
                    }
                    if (invert)
                        monochromeColor = (byte)(byte.MaxValue - monochromeColor);
                    outputBitmap.SetPixel(x, y, Color.FromArgb(monochromeColor, monochromeColor, monochromeColor));
                }
            }
            return outputBitmap;
        }
        public static Bitmap GetMonochromeBitmap(Image bitmap, bool invert = false)
        {
            return GetMonochromeBitmap((Bitmap)bitmap, invert);
        }
        public static Bitmap GetMonochromeBitmap(Bitmap bitmap)
        {
            return GetMonochromeBitmap(bitmap, false);
        }
        public static Bitmap GetMonochromeBitmap(Image bitmap)
        {
            return GetMonochromeBitmap((Bitmap)bitmap, false);
        }
    }
}
