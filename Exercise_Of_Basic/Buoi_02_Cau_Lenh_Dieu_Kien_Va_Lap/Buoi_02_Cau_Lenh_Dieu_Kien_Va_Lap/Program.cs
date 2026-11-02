using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.BaiTap;

namespace Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //BaiTap.BaiTap.BaiTap01();
            //BaiTap.BaiTap.BaiTap02();
            //BaiTap.BaiTap.BaiTap02_C2();
            BaiTap.BaiTap.BaiTap03();
            Console.WriteLine(BaiTap.BaiTap.BaiTap06("21"));
            Console.WriteLine(BaiTap.BaiTap.BaiTap06("15"));
            Console.WriteLine(BaiTap.BaiTap.BaiTap06("3005"));

        }
    }
}
