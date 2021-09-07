using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace ZangClass_Extension
{
    public static class ConvertImage
    {
        /// <summary>
        /// تبدیل عکس به باینری
        /// </summary>
        /// <param name="img">ورودی عکس</param>
        /// <returns>خروجی باینری</returns>
        public static byte[] ConvertImageToByte(Image img)  //--------- تبدیل عکس به باینری -------------
        {
            byte[] byteArray;
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);
                stream.Close();
                byteArray = stream.ToArray();
            }
            return byteArray;
        }
    }
}
