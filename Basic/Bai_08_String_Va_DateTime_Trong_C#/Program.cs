using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai_08_String_Va_DateTime_Trong_C_
{
    internal class Program
    {
        #region Học về Datetime :
        // Khởi tạo DataTime :
        public static void ViDu01()
        {
            
            DateTime datetimeDemo01 = new DateTime();
            Console.WriteLine($"- Thông tin giá trị thời gian datetimeDemo01 = {datetimeDemo01}");

            DateTime datetimeDemo02 = DateTime.UtcNow;
            Console.WriteLine($"- Thông tin giá trị thời gian datetimeDemo02 (Dùng UtvNow) = {datetimeDemo02}");

            DateTime datetimeDemo03 = DateTime.Now;
            Console.WriteLine($"- Thông tin giá trị thời gian datetimeDemo03 (Dùng Now) = {datetimeDemo03}"); 
        }

        //Cộng / trừ 1 khoản thời gian :
        public static void ViDu02()
        {
            Console.WriteLine("Cộng / Trừ 1 khoản thời gian !");
            DateTime dateTimeNow = DateTime.Now;
            Console.WriteLine($"- Thông tin thời gian biến dateTimeNow (Dùng .Now)  = {dateTimeNow}");
           
            // Cộng / trừ 1 khoản thời gian Cách 1 dùng các phương thức có tiền tố "Add" : 
            dateTimeNow =  dateTimeNow.AddSeconds(1);
            Console.WriteLine($"- Thông tin thời gian biến dateTimeNow sau khi cộng 1 giây  = {dateTimeNow}");

            dateTimeNow = dateTimeNow.AddHours(-1);
            Console.WriteLine($"- Thông tin thời gian biến dateTimeNow sau khi trừ 1 giờ  = {dateTimeNow}");

            dateTimeNow = dateTimeNow.AddYears(-9);
            Console.WriteLine($"- Thông tin thời gian biến dateTimeNow sau khi trừ 9 năm  = {dateTimeNow}");

            // Cộng / trừ 1 khoản thời gian Cách 2 dùng TimeSpan(Cac_Tham_So);
            TimeSpan tmp01 = new TimeSpan(2, 10 , 0);
            DateTime dateTimeUtcNow = DateTime.UtcNow;
            Console.WriteLine($"- Thông tin thời gian biến dateTimeUtcNow = {dateTimeUtcNow.ToString()}");
            dateTimeUtcNow = dateTimeUtcNow + tmp01;
            Console.WriteLine($"- Thông tin thời gian biến dateTimeUtcNow (Sau khi + TimeSpan) = {dateTimeUtcNow.ToString()}");

            TimeSpan tmp02 = new TimeSpan(-2 , -10 , 0);
            dateTimeUtcNow = dateTimeUtcNow.Add(tmp02);
            Console.WriteLine($"- Thông tin thời gian biến dateTimeUtcNow (Sau khi + TimeSpan) = {dateTimeUtcNow.ToString()}");

        }
        
        // Đo khoản cách 2 mốc thời gian : 
        public static void Vidu03()
        {
            DateTime dateTime01 = DateTime.UtcNow;
            DateTime dateTime02 = DateTime.Now;

            // Khoản thời gian từ .UtcNow đến Now là :
            Console.WriteLine("- Khoản thời gian hai mộc thời gian dateTime01 và dateTime02 là : {0}", dateTime01.Subtract(dateTime02));

            DateTime dateTime03 = DateTime.Now;
            DateTime dateTime04 = new DateTime(2000 , 1 , 1);
            Console.WriteLine("- Khoản thời gian hai mộc thời gian dateTime03 và dateTime04 là : {0}", dateTime03.Subtract(dateTime04).TotalDays);
            Console.WriteLine("- Khoản thời gian hai mộc thời gian dateTime03 và dateTime04 là : {0}", dateTime03.Subtract(dateTime04).TotalHours);

        }


        // So sánh hai  mốc thời gian :
        public static void ViDu04()
        {
            DateTime dateTime01 = new DateTime(2026 , 1 , 1);
            DateTime dateTime02 = DateTime.Now;
            var ketQuaSoSanh = dateTime01.CompareTo(dateTime02);
            Console.WriteLine($"- Giá trị trả về khi dateTime01 nhỏ hơn dateTime02 là {ketQuaSoSanh}");

            DateTime dateTime03 = new DateTime(2222, 1, 1);
            DateTime dateTime04 = DateTime.Now;
            var ketQuaSoSanh01 = dateTime03.CompareTo(dateTime04);
            Console.WriteLine($"- Giá trị trả vè khi dateTime03 lớn hơn dateTime04 là {ketQuaSoSanh01}");

            DateTime dateTime05 = DateTime.Now;
            DateTime dateTime06 = DateTime.Now;
            var ketQuaSoSanh02  = dateTime05.CompareTo(dateTime05);
            Console.WriteLine($"- Giá trị trả về khi dateTime05 bằng dateTime06 là {ketQuaSoSanh02}");

        }
        
        // Định dạng tiêu chuẩn DateTime :
        public static void ViDu05()
        {
            DateTime dateTime01 = DateTime.Now;
            Console.WriteLine($"- Định dạng 01 : {dateTime01.ToString("d/M/y : h:m:s")}");
            Console.WriteLine($"- Định dạng 02 : {dateTime01.ToString("dd/MM/yy : hh:mm:ss")}");
            Console.WriteLine($"- Định dạng 03 : {dateTime01.ToString("ddd/MMM/yyy : H:mm:ss")}");
            Console.WriteLine($"- Định dạng 04 : {dateTime01.ToString("dddd/MMMM/yyy : HH:mm:ss")}");
            DateTime dateTime02 = new DateTime(2021 , 1 , 1 , 3 , 11 , 4);
            Console.WriteLine($"- Định dạng 01 : {dateTime02.ToString("d/M/y : h:m:s")}");
            Console.WriteLine($"- Định dạng 02 : {dateTime02.ToString("dd/MM/yy : hh:mm:ss")}");
            Console.WriteLine($"- Định dạng 03 : {dateTime02.ToString("ddd/MMM/yyy : H:mm:ss")}");
            Console.WriteLine($"- Định dạng 04 : {dateTime02.ToString("dddd/MMMM/yyy : HH:mm:ss")}");

        }


        // Chuyển đổi sang DateTime :
        public static void ViDu06()
        {
            var dateTimeText = "10/04/2026";
            var dateTime01 = DateTime.ParseExact(dateTimeText, "dd/MM/yyyy" , CultureInfo.InvariantCulture);

        }
        #endregion

        #region Học về String :
        public static void ViDu07()
        {
            string str1 = "Nguyen VAN a";
            string str2 = "  Học lập trình C# !  ";
            
            Console.WriteLine("- Hai gía trị chuỗi ban đầu là :");
            Console.WriteLine($"str1 = {str1} \nstr2 = {str2}");
            // Phương thức nối hai chuỗi Concat() :
            string ketQua01 = String.Concat(str1, str2);
            Console.WriteLine($"- Cộng hai chuỗi ketQua01 = {ketQua01}");

            // Thay thế các ký tự trong chuỗi.
            string ketQua02 = str1.Replace(" ", "___");
            Console.WriteLine($"- Kết quả sau khi thay thế chuỗi ketQua02 = {ketQua02}");


            // Chuyển đổi string thành mảng chuỗi :
            var ketQua03 = str2.Split(' ');
            Console.WriteLine($"- Kết quả sau khi chuyển đổi string thàng mảng chuỗi ketQua03 = {ketQua03}");
            Console.WriteLine($"- Duyệt qua các phần tử trong mảng chuỗi ketQua03 : ");
            for (int i = 0; i < ketQua03.Length; i++)
            {
                Console.WriteLine($"ketQua03[{i}]  = {ketQua03[i]}");
            }

            // Lấy chuỗi con trong chuỗi cha :
            var ketQua04 = str1.Substring(0, 10);
            Console.WriteLine($"- Kết quả lấy chuỗi con ketQua04 = {ketQua04}");

            // Hoa - thường :
            string ketQua05 = str1.ToUpper();
            string ketQua06 = str2.ToLower();
            Console.WriteLine($"- Kết quả viết hoa - thường ketQua05 = {ketQua05} \t ketQua06 = {ketQua06} ");

            Console.WriteLine("- Hai gía trị chuỗi ban đầu là :");
            Console.WriteLine($"str1 = {str1} \nstr2 = {str2}");
        }


        #endregion

        static void Main(string[] args)
         {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Xin chào các bạn !");
            #region Học về Datetime :
            //ViDu01();
            //ViDu02();
            //Vidu03();
            //ViDu04();
            //ViDu05();
            //ViDu06();
            ViDu07();
            #endregion
        }
    }
}

// Lý thuyết về Datetime :
/*
I- Khái niệm :
- Datetime là một kiểu dữ liệu trong C#. Trong .NET FrameWork , System.Datatime là một struct
đại diện cho ngày tháng và thời gian.
- Giá trị của nó nằm tỏng khoản 12:00:00 ngày 01-01-0001 đến 11:59:59 ngày 31:12:9999 

1- Một số thuộc tính :
*) UtcNow : Là thuộc tính lấy thời gian UTC (UTC + 0)
-> Giá trị thời gian +7 tiếng so với giờ Việt Nam.
-> Mốc thời gian này dùng nhiều vì các server có thể đặt ở nhiều vị trí khác 
nhau (Nên không hay dùng .Now)

 *)Now : Lấy thời gian hiện tại của bạn (Phụ thuộc vào múi giờ )
- Việt Nam có UTC+7

2- Cộng trừ một khoản thời gian :
- Cách 1 : Dùng các phương thức có tiền tố "Add" để cộng trừ một khoản 
thời gian như : AddDays , AddHours , AddMilliseconds , AddMonths ,  AddYears , ...

- Cách 2 :  Dùng TimeSpan 

3- Đo khoản thời gian giữa hai mốc thời gian :
- Sử dụng phương thức .Subtract(dateTime);

4- So sánh hai mốc thời gian :
- Sử dụng phương thức .Compare()

5- Định dạng tiêu chuẩn Datetime :
-  Sử dụng phương thức .ToString() và truyền vào các tham số d , dd , h , H , m , yyyy , ...

6- Một số hàm hay dùng
- GetFirstDayInMonth ,  GetLastDayInYear , .......

7- Convert sang Datime :
- Sử dụng phương thức Datetime.PareExact(string , format) hoặc Datetime.Pares(string).
 */

// Lý thuyết về String :
/*
 I - Khái niệm :
- String là một kiểu dữ liệu dạng tham chiếu dùng để lưu trữ dữ liệu dưới dạng
chuỗi trong C#.

II - Một số thuộc tính và phương thức :
- Lenght : Lấy số ký tự của đối tượng String hiện tại.
- Compare(string strA , string strB) : So sánh hai đối tượng chuỗi cụ thể và trả về một
interger mà chỉ vị trí có liên quan của chúng trong thứ tự xắp sếp.
- Convert(string str1 , string str2) : Nối hai chuỗi.
- Replace(char oldChar , char newChar) : Thay thế tắt cả ký tự oldChar bằng ký tự newChar và trả về chuỗi mới.
- Remove(int startIndex , int count) : Trả về một chuỗi mới với một số ký tự bị xóa count , bắt đầu từ vị trí startIndex.
- Split(params char[]separator) : Trả về một mảng chuỗi , là các chuỗi được phân mởi bằng ký tự separator.
- Substring(index , count) : Trả về một chuỗi con bắt đầu từ vị trí index có độ dài count.
- ToUpper để viết hoa và ToLower để viết thường.


III - Lớp StringBuilder 
- Lớp StringBuilder đưucoj .NET xây dựng sẵn giúp chúng ta thao tác trực tiếp với chuỗi gốc và giúp
tiết kiệm bộ nhớ hơn so với lớp String .

-> Đặc điểm của lớp Stringbuilder là :
- Cho phép tháo tác trực tiếp trên chuỗi ban đầu.
- Có khả năng mở rộng vùng nhớ khi cần thiết.
- Không cho phép lớp khác kế thừa.
 */