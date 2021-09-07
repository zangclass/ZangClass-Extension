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

        /// <summary>
        /// تبدیل عکس به باینری به وسیله آدرس عکس در حافظه سیستم
        /// </summary>
        /// <param name="fileName">آدرس تصویر</param>
        /// <returns>خروجی باینری</returns>
        public static byte[] ConvertImageToByte(string fileName)
        {
            byte[] buffer = null;
            try
            {
                var fs = new FileStream(fileName, FileMode.Open);
                buffer = new byte[fs.Length];
                fs.Read(buffer, 0, Convert.ToInt32(fs.Length));
                fs.Close();
            }
            catch (Exception)
            {
                // ignored
            }
            return buffer;
        }
    }
}
