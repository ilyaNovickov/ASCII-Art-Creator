using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIArtWinFormsApp
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
        public static Bitmap BlackAndWhiteCreator(Bitmap bitmap)
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
                    UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
            return output;
        }
        public static Bitmap BlackAndWhiteCreator(Image bitmap)
        {
            return BlackAndWhiteCreator((Bitmap)bitmap);
        }
    }
}
