using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai_07_Xu_Ly_Ngoai_Le_Exception_Handling
{
    internal class Program
    {
        #region Vi_Du_01
        static void DemoException01(int a, int b)
        {
            // Chia 2 số không sử dụng Exception 
            int chiaKetQua = a / b;
            Console.WriteLine($"{a}/{b} = {chiaKetQua}");
        }
        static void DemoException02(int a, int b)
        {
            // Chia 2 số có sử dụng Exception :
            try
            {
                int chiaKetQua = a / b;
                Console.WriteLine($"{a}/{b} = {chiaKetQua}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Lỗi chia cho 0 !");
            }
        }
        #endregion

        #region Sử dụng một số phương thức của Exception.
        public static void DemoException03()
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                int item = arr[3];
                Console.WriteLine($"- Giá trị item = {0}", item);
            }
            catch (Exception ex)
            {
                Console.WriteLine("- Các thông tin trong khối catch () : ");
                Console.WriteLine(ex);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
            }
            finally
            {
                Console.WriteLine("- Đã gọi phương thứ DemoException03() !");
            }
        }
        #endregion

        #region Sử dụng Exception riêng.

        public class DataTooLongException : Exception
        {
            const string errorMessage = "Dữ liệu chuỗi quá dài !";
            public DataTooLongException() : base(errorMessage) { }
        }
        public static void DemoException04()
        {
            try
            {
                string str = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                if (str.Length > 10) {
                    Exception ex  = new DataTooLongException();
                    throw ex;
                }

            }
            catch(DataTooLongException ex)
            {
                Console.WriteLine("- Thông tin về ex : ");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);


            }
            finally
            {
                Console.WriteLine("Đã gọi phương thức DemoException04() !");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Demo_Vi_Du_01
            //int x = 0; int y = 0;
            //DemoException02(x, y);
            //DemoException01(x, y);
            #endregion

            #region Demo_Vi_Du_02 
            //DemoException03();
            #endregion

            #region Demo_Vi_Du_03
            //DemoException04();
            #endregion
        }
    }
}

// Lý thuyết :
/*
 - Ta có cú pháp Exception như sau :
    try{
        // Các khối code được giám sát để bắt  lỗi nếu có.
        // Nếu có lỗi phát sinh ngoại lệ Exception.
        // Ngoại lệ này bắt được ở khối code.
    }
    catch(Exception ex)
    {
        // Khối lệnh này thực thi khi có lỗi.
        // Đối tượng Exception bắt được lửum ở biến lỗi.
    }   
    finally
    {
        // Khối lệnh luôn được thực thi dù có phát sinh lỗi hay không.
    }

- Một số thuộc tính của Exception :
    + Message : Chuỗi chứa nội dung thông báo lỗi.
    + StackTrace : Chuỗi chứa các nội dung liên quan như các phương thức , hàm khi thực thi gây lỗi ,
vị trí file lỗi , .........
    +Source : Chứa tên ứng dụng hoặc đối tượng gây lỗi.
 
- Trong C# có một số Exception được xây dựng trước :
    FileNotFoundExceoption ,  FormatException  , OutOfMemoryException , ArgumentException ,
NullReferceException , IndexOutOfRangeException , DeviceByZeroException , .....
 */