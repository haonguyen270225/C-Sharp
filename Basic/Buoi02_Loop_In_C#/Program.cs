using Bai02BissinesLogicLayer.ViDu;
using Buoi02Common.Integer;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Buoi02_Loop_In_C_
{
    internal class Program
    {
        // Ví dụ 01 : Sử dụng dòng for duyệt qua các số nguyên lẻ từ 1 -> n !
        public static void HienThiSoNguyenLe()
        {
            //ViDu1 vd1 = new ViDu1();
            int n;
            bool isChecked;
            Console.WriteLine("- Nhập một số nguyên từ bàn phím : ");
            n =  CheckInput.IntegerValue(Console.ReadLine() , out isChecked);
            if(isChecked == false)
            {
                switch (n)
                {
                    case -1:
                        Console.WriteLine("- Gía trị số nguyên không được để trống !");
                        return;
                    case -2:
                        Console.WriteLine("- Giá trị số nguyên không được rỗng !");
                        return;
                    case -3:
                        Console.WriteLine("- Giá trị không hợp lệ !");
                        return;
                }
            }
            
            List<int> listOfInteger = ViDu1.ViDu01OfDuyetQuaSoLe(n);
            if (listOfInteger.Count > 0)
            {
                Console.WriteLine($"- Số nguyên lẻ từ 1 -> {n} là : {listOfInteger.Count}");
                foreach (int item in listOfInteger)
                {
                    Console.Write(item + "\t");
                }
            }
            else
            {
                Console.WriteLine($"- Số nguyên lẻ từ 1 -> {n} là : 0");
            }


        }

        // Ví dụ 02 : Sử dụng cấu trúc while . Nhập một số nguyên không âm
        // nếu là số âm hoặc không hợp lệ thì yêu cầu nhập lại.
        public static void NhapSoNguyenKhongAm()
        {
            Console.WriteLine("- Vui lòng nhập một số nguyên không âm : ");
            int value = ViDu2.NhapSoNguyenKhongAm(Console.ReadLine());
            while(value < 0)
            {
                if(value == -1)
                {
                    Console.WriteLine("- Giá trị số nhập không được để rổng !");
                    Console.WriteLine("- Vui lòng nhập lại số nguyên không âm : ");
                    value = ViDu2.NhapSoNguyenKhongAm(Console.ReadLine());
                }else if(value == -2)
                {
                    Console.WriteLine("- Giá trị không được rỗng !");
                    Console.WriteLine("- Vui lòng nhập lại số nguyên không âm : ");
                    value = ViDu2.NhapSoNguyenKhongAm(Console.ReadLine());
                }else if(value == -3)
                {
                    Console.WriteLine("- Giá trị nhập vào không hợp lệ (- Không được quá lớn hoặc chứa ký tự không hợp lệ ) !");
                    Console.WriteLine("- Vui lòng nhập lại số nguyên không âm : ");
                    value = ViDu2.NhapSoNguyenKhongAm(Console.ReadLine());
                }else if( value == -4)
                {
                    Console.WriteLine("- Giá trị nhập không được âm !");
                    Console.WriteLine("- Vui lòng nhập lại số nguyên không âm : ");
                    value = ViDu2.NhapSoNguyenKhongAm(Console.ReadLine());
                }
            }
            Console.WriteLine($"- Giá trị số nguyên không âm bạn vừa nhập là : {value}");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //HienThiSoNguyenLe();
            NhapSoNguyenKhongAm();
            
        }
    }
}
