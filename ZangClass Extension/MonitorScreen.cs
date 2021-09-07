using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
//using System.Windows.Form;

namespace ZangClass_Extension
{
    public static class MonitorScreen
    {
        /// <summary>
        /// عکس گرفتن از صفحه نمایش کل مانیتور
        /// </summary>
        /// <returns></returns>
        public static void PrintScreen()
        //public static Bitmap PrintScreen()
        {
            // چون کلاس screen در داتنت فریم ورک هست و این پروژه در دات نت استاندارد هست باید جایگزینش رو پیدا کنم 
            //Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //Graphics graphics = Graphics.FromImage(printscreen);
            //graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size - (new Size()));
            //return printscreen;
        }
    }
}
