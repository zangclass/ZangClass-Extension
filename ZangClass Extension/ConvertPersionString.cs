using System;
using System.Collections.Generic;
using System.Text;

namespace ZangClass_Extension
{
    public static class ConvertPersionString
    {
        public static string PersionString(this string text)
        {
            return text.Replace("ﮎ", "ک").
                Replace("ﮏ", "ک").
                Replace("ﮐ", "ک").
                Replace("ﮑ", "ک").
                Replace("ك", "ک").
                Replace("ي", "ی");
        }
        public static string Fa2En(this string text)
        {
            return text.Replace("۰", "0").
                Replace("۱", "1").
                Replace("۲", "2").
                Replace("۳", "3").
                Replace("۴", "4").
                Replace("۵", "5").
                Replace("۶", "6").
                Replace("۷", "7").
                Replace("۸", "8").
                Replace("۹", "9");
        }

        public static string En2Fa(this string text)
        {
            return text.Replace("0", "۰").
                Replace("1", "۱").
                Replace("2", "۲").
                Replace("3", "۳").
                Replace("4", "۴").
                Replace("5", "۵").
                Replace("6", "۶").
                Replace("7", "۷").
                Replace("8", "۸").
                Replace("9", "۹");
        }
    }
}
