using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASCIIArtWinFormsApp_dotNet_Framework_
{
    internal static class AsciiArtCreator
    {
        private static string formatName;
        private static Dictionary<string, string[]> formats = new Dictionary<string, string[]>();
        static AsciiArtCreator()
        {
            formatName = "Two";
            formats.Add("Two", new string[] { "░", "█" });
            formats.Add("Four", new string[] { "░", "▒", "▓", "█" });
            formats.Add("Many", new string[] { ".", ",", ";", "+", "*", "?", "%", "$", "#", "@" });
            formats.Add("Many2", new string[] { ".", ",", ";", "+", "*", "?", "%", "$", "#", "@", "█" });
        }
        public static string ArtFormat
        {
            get { return formatName; }
            set
            {
                if (formats.ContainsKey(value))
                    formatName = value;
                else
                    formatName = "Two";
            }
        }
        public static Dictionary<string, string[]> Formats
        {
            get => formats;
        }
        public static void AddNewFormat(string formatName, string[] symbolsArray)
        {
            if (formatName == null || formatName == "" || symbolsArray == null || symbolsArray.Length == 0)
                return;
            if (formats.ContainsKey(formatName))
                return;
            formats.Add(formatName, symbolsArray);
        }
        public static string MakeArt(Bitmap bitmap)
        {
            string symbolArt = "";
            for (int i = 0; i < bitmap.Height; i++)
            {
                string line = "";
                for (int j = 0; j < bitmap.Width; j++)
                {
                    line += ASCIIMapping(bitmap.GetPixel(j, i).R, formatName);
                }
                line += "\n";
                symbolArt += line;
            }
            return symbolArt;
        }
        public static string MakeArt(Image bitmap)
        {
            return MakeArt((Bitmap)bitmap);
        }
        private static string ASCIIMapping(int colorValue, string formatName)
        {
            if (!formats.ContainsKey(formatName))
                return "";
            int indx = ((int)((double)((double)formats[formatName].Length / 256d) * (double)colorValue));
            return formats[formatName][indx];
        }
    }
}
