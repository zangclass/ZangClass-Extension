using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// تبدیل باینری به تصویر به وسیله داده هایی که در دیتاتیل وجود دارد
        /// </summary>
        /// <param name="dt">دیتاتیبلی که از بانک و یا هر جای دیگر پر شده</param>
        /// <param name="row">سطر مورد نظری که عکس ان مورد نیاز است</param>
        /// <param name="columnName">اسم ستون عکس در دیتاتیبل که باینری است</param>
        /// <returns>خروجی یک عکس</returns>
        public static Bitmap ConvertBinaryToBitmap(DataTable dt, int row, string columnName)
        {
            if (dt.Rows[row][columnName] == DBNull.Value) return null;
            var ms = new MemoryStream((byte[])dt.Rows[row][columnName]);
            Bitmap bmpBitmap = new Bitmap(ms);
            return bmpBitmap;
        }

        /// <summary>
        /// تبدیل باینری به عکس به وسیله متغیر باینری
        /// </summary>
        /// <param name="pictur">ورودی عکس باینری</param>
        /// <returns>خروجی عکس</returns>
        public static Bitmap ConvertBinaryToBitmap(byte[] pictur)
        {
            if (pictur == null) return null;
            var ms = new MemoryStream(pictur);
            Bitmap bmpBitmap = new Bitmap(ms);
            return bmpBitmap;
        }
    }
}
