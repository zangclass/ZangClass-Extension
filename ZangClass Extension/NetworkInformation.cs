using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ZangClass_Extension
{
    public static class NetworkInformation
    {
        /// <summary>
        /// بدست آوردن آدرس آی پی سیستم جاری
        /// </summary>
        /// <returns>خروجی آدرس IP</returns>
        public static string GetIpAddress()
        {
            //return new IPHostEntry().AddressList[0].ToString();
            return Dns.GetHostEntry(Dns.GetHostName())
                .AddressList.First(f => f.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                .ToString();
        }

        /// <summary>
        /// بدست آوردن نام کامپیوتر سیستم جاری
        /// </summary>
        /// <returns>خروجی نام کامپیوتر</returns>
        public static string GetComputerName()
        {
            return Dns.GetHostName();
        }
    }
}
