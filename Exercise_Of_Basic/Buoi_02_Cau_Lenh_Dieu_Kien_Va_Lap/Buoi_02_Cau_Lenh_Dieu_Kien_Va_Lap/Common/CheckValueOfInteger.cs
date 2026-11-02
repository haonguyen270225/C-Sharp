using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.Common
{
    internal class CheckValueOfInteger
    {
         //public static bool CheckValueOfNull(int? value)
         //{
         //   if(value is null)
         //   {
         //       Console.WriteLine("Error : Giá trị số nguyên rỗng !");
         //       return true;
         //   }
         //   else
         //   {
         //       return false;
         //   }
         //}
        public static bool CheckValueOfMinAndMax(int value) {
            if (value < int.MinValue || value > int.MaxValue){
                Console.WriteLine("Error : Giá trị số nguyên không hợp lệ ( không được quá nhỏ hoặc quá lơn )!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsInteger(string value , out int valueInteger) {
            bool isInteger = int.TryParse(value, out valueInteger);
            if (!isInteger)
            {
                Console.WriteLine("Error : Giá trị số nguyên không hợp lê !");
                return false;
            }
            else
            {
                if(CheckValueOfMinAndMax(valueInteger))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
