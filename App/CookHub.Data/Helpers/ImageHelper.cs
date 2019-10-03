using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace CookHub.Data.Helpers
{
    internal static class ImageHelper
    {
        internal static byte[] GetImageData(string imagePath)
        {
            var data = File.ReadAllBytes(imagePath);
            var ms = new MemoryStream();
            Image img = Image.FromFile(imagePath);
            img.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
