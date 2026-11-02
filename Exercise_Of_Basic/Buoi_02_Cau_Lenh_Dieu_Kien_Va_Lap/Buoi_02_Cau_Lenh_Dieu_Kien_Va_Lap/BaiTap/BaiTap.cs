using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.Common;

namespace Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.BaiTap
{
    internal class BaiTap
    {
        // Bài tập 01 : Kiểm tra 1 số có phải là số nguyên tố ?.
        public static void BaiTap01()
        {
            int number;
            Console.Write("- Nhập một số kiểm tra số nguyên tố : ");
            bool resultOfInput = CheckValueOfInteger.IsInteger(Console.ReadLine(),out number);
            if (!resultOfInput)
            {
                Console.WriteLine("- Bài tập 01 không thành công !");
                return;
            }
            else
            {
                if (!Common.Prime.ISPrime(number))
                {
                    Console.WriteLine($"- {number} không phải số nguyên tố !");
                }
                else
                {
                    Console.WriteLine($"- {number} Là số nguyên tố !");
                }
            }
                
            
        }

        // Bài tập 02 : In ra danh sách các số nguyên tố từ 1 -> N . N nhập từ bàn phím ?
        // Cách 1 : Đơn giản nhất :
        public static void BaiTap02()
        {
            int N;
            Console.Write("- Nhập giá trị số nguyên từ bàn phím :");
            bool resultOfInput = CheckValueOfInteger.IsInteger(Console.ReadLine() ,out N);
            // Sử dụng toán tử điều kiện :
            if (!resultOfInput)
            {
                Console.WriteLine("- Bài tập 02 không thành công !");
                return;
            }
            for (int i = 1; i <= N; i++)
            {
                if (Common.Prime.ISPrime(i))
                {
                    Console.Write($"{i}\t");
                }
            }
        }

        // Cách 2 : Áp dụng với giá trị N tối đa 10^6;
        public static void BaiTap02_C2()
        {
            int N;
            Console.Write("- Nhập giá trị số nguyên từ bàn phím :");
            bool resultOfInput = CheckValueOfInteger.IsInteger(Console.ReadLine(), out N);
            // Sử dụng toán tử điều kiện :
            if (!resultOfInput)
            {
                Console.WriteLine("- Bài tập 02 không thành công !");
                return;
            }
            Common.Prime.Sieve();
            for (int i = 1; i <= N; i++)
            {
                if (Common.Prime.prime[i] == 1)
                {
                    Console.Write($"{i}\t");
                }
            }
        }

        // Bài tập 03 : Tính giai thừa của một số ?
        public static void BaiTap03()
        {
            int N;
            Console.Write("- Nhập giá trị số nguyên từ bàn phím :");
            bool resultOfInput = CheckValueOfInteger.IsInteger(Console.ReadLine(), out N);
            // Sử dụng toán tử điều kiện :
            if (!resultOfInput)
            {
                Console.WriteLine("- Bài tập 03 không thành công !");
                return;
            }
            Console.WriteLine($"Kết quả {N}! = {GiaiThua.ResultOfGiaiThua(N)}");
        }


        // Bài tập 04 : Nhập vào số nguyên bất kỳ và in ra chữ tương ứng :
        public static string BaiTap06(string str)
        {
            string[] word = { "", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
            string[] million = { "", " mươi", " trăm", "" };
            string[] billion = { "", "", "", " nghìn", "", "", " triệu", "", "" };
            string result = "{0}";
            int count = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (count > 0 && count % 9 == 0)
                    result = string.Format(result, "{0} tỷ");
                if (!(count < str.Length - 3 && count > 2 && str[i].Equals('0') && str[i - 1].Equals('0') && str[i - 2].Equals('0')))
                    result = string.Format(result, "{0}" + billion[count % 9]);
                if (!str[i].Equals('0'))
                    result = string.Format(result, "{0}" + million[count % 3]);
                else if (count % 3 == 1 && count > 1 && !str[i - 1].Equals('0') && !str[i + 1].Equals('0'))
                    result = string.Format(result, "{0} lẻ");
                var num = Convert.ToInt16(str[i].ToString());
                result = string.Format(result, "{0}" + word[num]);
                count++;
            }
            result = result.Replace("{0}", "");
            return result.Trim();
        }
    }
}
