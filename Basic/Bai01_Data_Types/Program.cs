using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01_Data_Types
{
    internal class Program
    {
        //Hàm chỉnh màu chữ - chữ đỏ nền trắng :
        static void ChangeBackgroundOfHeader()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
        }

        // Hàm chỉnh màu chữ - chữ xanh nền đen :
        static void ChangeBackgroundOfInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /* 1. Khai báo và sử dụng số nguyên ! */
        #region 1. Khai báo và sử dụng số nguyên !
        static void Integer()
        {
            ChangeBackgroundOfHeader();
            //Console.WriteLine("██████████████████ BANNER TIÊU ĐỀ ██████████████████");
            Console.WriteLine("================ Sử dụng Kiểu số nguyên (int) ================");
            /*
             Có các kiểu khai báo số nguyên sau : 
            int , Int16 , Int32 , Int64 , uint (Chỉ chứa số dương < gần 4 tỷ) , short , ushort (Không nguyên không âm < 6000)
            long , ulong
             */
            /* 1. Khai báo và sử dụng số nguyên ! */
            ChangeBackgroundOfInfo();
            Console.WriteLine($"int : {sizeof(int)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất int có thể lưu trữ : " + int.MinValue + " (Sắp xỉ âm 2 tỷ)");
            Console.WriteLine("Giá trị lớn nhất int có thể lưu trữ : " + int.MaxValue + " (Sắp xỉ 2 tỷ)");
            int variable_1 = 23;
            int variable_2 = 1000;
            Console.WriteLine(variable_1);
            Console.WriteLine("variable_2 = {0}", variable_2);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Dụng số nguyên : Int16 ");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"Int16 : {sizeof(Int16)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất Int16 có thể lưu trữ : " + Int16.MinValue);
            Console.WriteLine("Giá trị lớn nhất Int16 có thể lưu trữ : " + Int16.MaxValue);
            // Sử số nguyên 2 bytes , 4 bytes và 8 bytes :
            Int16 variable_3 = -32768;                                // Giá trị tối đa : -32.768 tới 32.767
            Int16 variable_4 = 32767;                                // Giá trị tối đa : -32.768 tới 32.767
            Console.WriteLine("- Giá trị tối thiểu mà Int 2 bytes (Int16) có thể chứa là : {0}", variable_3);
            Console.WriteLine("- Giá trị tối đa  mà Int 2 bytes (Int16) có thể chứa là : {0}", variable_4);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Dụng số nguyên : Int32 ");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"Int32 : {sizeof(Int32)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất Int32 có thể lưu trữ : " + Int32.MinValue + " (Sắp xỉ âm 2 tỷ)");
            Console.WriteLine("Giá trị lớn nhất Int32 có thể lưu trữ : " + Int32.MaxValue + " (Sắp xỉ 2 tỷ)");
            Int32 variable_5 = -2000000000;                           // Giá trị có độ - 2 tỷ tới 2 tỷ. 
            Int32 variable_6 = -2000000000;                           // Giá trị có độ - 2 tỷ tới 2 tỷ.
            Console.WriteLine("- Giá trị tối thiểu mà Int 4 bytes (Int16) có thể chứa là : {0}", variable_5);
            Console.WriteLine("- Giá trị tối đa  mà Int 4 bytes (Int16) có thể chứa là : {0}", variable_6);

            
            ChangeBackgroundOfHeader();
            Console.WriteLine("► Dụng số nguyên : Int64 ");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"Int64 : {sizeof(Int64)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất Int64 có thể lưu trữ : " + Int64.MinValue + " (Sắp xỉ âm rất lớn)");
            Console.WriteLine("Giá trị lớn nhất Int64 có thể lưu trữ : " + Int64.MaxValue + " (Sắp xỉ dương rất lớn)");
            Int64 variable_7 = -400000000000000;                     // Giá nhỏ nhất.
            Int64 variable_8 = 400000000000000;                      // Giá lớn nhất.
            Console.WriteLine("- Giá trị tối thiểu mà Int 8 bytes (Int16) có thể chứa là : {0}", variable_7);
            Console.WriteLine("- Giá trị tối đa mà Int 8 bytes (Int16) có thể chứa là : {0}", variable_8);



            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số nguyên : uint (unsigned int)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("Giá trị nhỏ nhất uint có thể lưu trữ : " + uint.MinValue);
            Console.WriteLine("Giá trị lớn nhất uint có thể lưu trữ : " + uint.MaxValue);
            Console.WriteLine($"uint : {sizeof(uint)} bytes");
            uint variable_9 = 70000;                        // Không chứa số âm và số dương lớn hơn 4294967295 ($ tỷ)
            Console.WriteLine(variable_9);



            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số nguyên : short (số nguyên 2 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("Giá trị nhỏ nhất short có thể lưu trữ : " + short.MinValue);
            Console.WriteLine("Giá trị lớn nhất short có thể lưu trữ : " + short.MaxValue);
            Console.WriteLine($"short : {sizeof(short)} bytes");
            short variable_10 = -230;                         // Số âm nhỏ nhất có thể chứ :  -32768
            short variable_11 = 230;                         // Số dương lớn nhất có thể chứ : 32767
            Console.WriteLine("Sử dụng kiểu short chứa số âm : {0}", variable_10);
            Console.WriteLine("Sử dụng kiểu short chứa số dương : {0}", variable_11);

            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số nguyên : ushort (số nguyên không âm)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("Giá trị nhỏ nhất ushort có thể lưu trữ : " + ushort.MinValue);
            Console.WriteLine("Giá trị lớn nhất ushort có thể lưu trữ : " + ushort.MaxValue);
            Console.WriteLine($"ushort : {sizeof(ushort)} bytes");
            ushort variable_12 = 0;                         // Số nhỏ nhất có thể chứa : 0
            ushort variable_13 = 60000;                         // Số dương lớn nhất có thể chứa : 65535
            Console.WriteLine("Sử dụng kiểu ushort chứa số âm : {0}", variable_12);
            Console.WriteLine("Sử dụng kiểu ushort chứa số dương : {0}", variable_13);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số nguyên : long (số nguyên 8 byte)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("Giá trị nhỏ nhất long có thể lưu trữ : " + long.MinValue);
            Console.WriteLine("Giá trị lớn nhất long có thể lưu trữ : " + long.MaxValue);
            Console.WriteLine($"long : {sizeof(long)} bytes");
            long variable_14 = -99999999999;                         // Số rất nhỏ !
            long variable_15 = 9999999999999;                         // Số rất lớn !
            Console.WriteLine("Sử dụng kiểu long chứa số âm : {0}", variable_14);
            Console.WriteLine("Sử dụng kiểu long chứa số dương : {0}", variable_15);

            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số nguyên : ulong (Số nguyên không âm 8 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("Giá trị nhỏ nhất ulong có thể lưu trữ : " + ulong.MinValue);
            Console.WriteLine("Giá trị lớn nhất ulong có thể lưu trữ : " + ulong.MaxValue);
            Console.WriteLine($"ulong : {sizeof(ulong)} bytes");
            ulong variable_16 = 0;                         // Số nhỏ nhất 0 - Không lưu số âm
            ulong variable_17 = 9999999999999;             // Số rất lớn !
            Console.WriteLine("Sử dụng kiểu ulong chứa số âm : {0}", variable_16);
            Console.WriteLine("Sử dụng kiểu ulong chứa số dương : {0}", variable_17);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số ký tự : char (2 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine("\nGiá trị nhỏ nhất char có thể lưu trữ : " + (int)char.MinValue);
            Console.WriteLine("Giá trị lớn nhất char có thể lưu trữ : " + (int)char.MaxValue);
            Console.WriteLine($"char : {sizeof(char)} bytes");
            char variable_18 = 'a';
            char variable_19 = 'A';
            char variable_20 = 'z';
            char variable_21 = 'Z';
            Console.WriteLine("Sử dụng kiểu char ký tự : {0} - Có giá trị là {1} ", variable_18, (int)variable_18);
            Console.WriteLine("Sử dụng kiểu char ký tự  : {0} - Có giá trị là {1} ", variable_19, (int)variable_19);
            Console.WriteLine("Sử dụng kiểu char ký tự  : {0} - Có giá trị là {1} ", variable_20, (int)variable_20);
            Console.WriteLine("Sử dụng kiểu char ký tự  : {0} - Có giá trị là {1} ", variable_21, (int)variable_21);

        }
        #endregion

        #region 2. Khai báo và sử dụng kiểu số thực (Floating Point)
        static void FloatingPoint()
        {
            ChangeBackgroundOfHeader();
            Console.WriteLine("================ Kiểu số số thực ==============");
            /*
             Có các kiểu khai báo số thực sau : 
             float , double , long double.
             
             */
            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số thực : float (4 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"float : {sizeof(float)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất char có thể lưu trữ : " + float.MinValue);
            Console.WriteLine("Giá trị lớn nhất char có thể lưu trữ : " + float.MaxValue);
            float variable_1 = 0.12f;                                           // Giới hạn 6 vị trí thập phân.
            float variable_2 = 5.789f;                                          // Giới hạn 6 vị trí thập phân.
            Console.WriteLine("Giá trị số thực float : {0}", variable_1);
            Console.WriteLine("Giá trị số thực float : {0}", variable_2);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số thực : double (8 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"double : {sizeof(double)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất double có thể lưu trữ : " + double.MinValue);
            Console.WriteLine("Giá trị lớn nhất double có thể lưu trữ : " + double.MaxValue);
            double variable_3 = 0.12f;                                           // Giới hạn 15 vị trí thập phân.
            double variable_4 = 5.789f;                                          // Giới hạn 15 vị trí thập phân.
            Console.WriteLine("Giá trị số thực double : {0}", variable_3);
            Console.WriteLine("Giá trị số thực double : {0}", variable_4);


            ChangeBackgroundOfHeader();
            Console.WriteLine("► Khai báo số thực : decimal (8 bytes)");
            ChangeBackgroundOfInfo();
            Console.WriteLine($"decimal : {sizeof(decimal)} bytes");
            Console.WriteLine("Giá trị nhỏ nhất decimal có thể lưu trữ : " + decimal.MinValue);
            Console.WriteLine("Giá trị lớn nhất deciaml có thể lưu trữ : " + decimal.MaxValue);
            decimal variable_5 = 0.12m;                                           // Giới hạn 28 vị trí thập phân.
            decimal variable_6 = 5.789m;                                          // Giới hạn 28 vị trí thập phân.
            Console.WriteLine("Giá trị số thực decimal : {0}", variable_5);
            Console.WriteLine("Giá trị số thực decimal : {0}", variable_6);
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Integer();
            FloatingPoint();
        }
    }
}
// - Trong C# (C Shrap) có 2 loại kiểu dữ liệu chính là : Value Types (Kiểu giá trị ) và Reference Types(Kiểu tham chiếu).
/*
 1. Kiểu giá trị (Value Types) có các loại sau :
- Simple Types (Kiều đơn giản / Kiểu nguyên thủy ) : Integer , Character , Boolean , Floating Point . (Chúng ta sẽ tìm hiểu các phần này trước !).
- Enum Types
- Struct Types
- Nullable Types

2. Kiểu tham chiếu (Reference Types) có các loại sau :
- Class Types
- Interface Types
- Array Types
- Delegate Types
 */