using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Bai_09_Generic_va_Collection
{
    #region Sử dụng Generic với class :
    public class GenericOfClass<T>
    {
        public T properties {  get; set; }

        // Phương thức :
        public T Display()
        {
            return properties;
        }
    }
    #endregion
    internal class Program
    {
        #region Ví dụ về Nạp chồng (Overloading) phương thức : 
        /*
         - Trong C# chúng ta có thể định nghĩa những hàm trùng tên nhưng cần phải thỏa mãn các điều kiện sau :
            + Khác số lượng tham số truyền vào hàm.
            + Khác kiểu trả về 
            + Khác kiểu dữ liệu của tham số.
        - Ví dụ : Nạp chồng phương thức TinhTong() như sau : 
         */
        public static void TinhTong(int soThu1 , int soThu2)
        {
            Console.WriteLine("----------------- Gọi hàm tính tổng số nguyên !-----------------");
            int soKetQua = soThu1 + soThu2;
            Console.WriteLine("- Kết quả là {0}", soKetQua);
        }

        //public static int TinhTong(int soThu1 , int soThu2)  // Lỗi không định nghĩa được phương thức này vì C# không phân
                                                                // phân biệt được hàm qua kiểu trả về.
        //{
        //    int soKetQua = soThu1 + soThu2;
        //    return soKetQua;
        //}
        public static float TinhTong (float soThu1 , float soThu2)
        {
            Console.WriteLine("----------------- Gọi hàm tính tổng số thực (float) !-----------------");
            float soKetQua = soThu1 + soThu2;
            return soKetQua;
        }

        public static string TinhTong(string str1 , string str2)
        {
            Console.WriteLine("----------------- Gọi hàm cộng chuỗi (string) !-----------------");
            string strKetQua = str1 + str2;
            return strKetQua;
        }

        public static double TinhTong(double soThu1 , double soThu2)
        {
            Console.WriteLine("----------------- Gọi hàm tính tổng số thực (double) !-----------------");
            double soKetQua = soThu1 + soThu2;
            return soKetQua;
        }
        #endregion

        #region Học về Generic :
        /*
        I) Khái niệm : 
        - Generic là kiểu dữ liệu đại diện cho các kiểu dữ liệu còn lại như int , bool , string , ...
        - Tùy vào mục đích sử dụng mà nó đại diện cho các kiểu dữ liệu khác nhau.
        - Generic được định nghĩa bằng cách sử dụng các từ khóa <>. Trong .Net có sẵn trong namespace : System.Collection.Generic. 
        II) Lợi ít hi dùng :
        - Giúp tối ưu hóa code sử dụng lại code (chỉ cần một hàm mà có thể tái sử dụng lại nhiều lần cho nhiều kiểu dữ liệu)
        , an toàn và ttanwg tốc độ.
        - Có thể sùng Generic với interface , classer , methods , events , delegates và structs.
        - Có thể tạo generic class với ràng buộc cho các methods trong class.
        
        - Ví dụ : Sử dụng generic với hàm TinhNhan();
         */
        public static T TinhNhan<T>(T soThuNhat, T soThuHai)
        {
            dynamic a = soThuNhat;
            dynamic b = soThuHai;
            return a * b;
        }

        #endregion

        #region Học về Collection :
        /*
         I) Khái niệm :
        - Collection là một tập hợp các kiểu dữ liệu không cùng kiểu.
        -  Collection cung cấp các methods giúp lập tình viên thao tác với dữ liệu
        một các đơn giản và dễ dàng.
        - Collection thuộc thư viện System.Collection.
        - Tròng C# , Collection được sử dụng với nhiều mục đích khác nhau như cấp phát
        bộ nhớ động cho các phần tử hay truy cập một danh sách các item dựa trên index , ....
        - Các Collection phổ biến như :
                + Dictionary 
                + List
                + ArrayList
                + SortedList
                + HashTable
                + Stack - Ngăn xếp.
                + Queue - Hàng đợi.
                + HashSet
        
         */
        

        #endregion
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("- Làm việc với Generic và  Collection : ");
            #region Ví dụ về Nạp chồng (Overloading) : 
            //TinhTong(10, 100);
            //Console.WriteLine("- Kết quả tổng số thực float : {0}", TinhTong(2.5f, 6.2f));
            //Console.WriteLine("- Kết quả tổng số thực double : {0}", TinhTong(2.5, 6.2));
            //Console.WriteLine("- Kết quả cộng chuỗi string : {0}", TinhTong("Nguyen" , " Lại học lập trình !"));
            #endregion

            #region Làm việc với Generic :
            ////Console.WriteLine("- Hàm tính nhân sử dụng Generic : {0}", TinhNhan<string>("Nguyen Van A", "Nguyen Van B"));
            //Console.WriteLine("- Hàm tính nhân sử dụng Generic : {0}", TinhNhan<int>(12, 10));
            //Console.WriteLine("- Hàm tính nhân sử dụng Generic : {0}", TinhNhan<float>(12.4f, 10f));
            //Console.WriteLine("- Hàm tính nhân sử dụng Generic : {0}", TinhNhan<double>(13.1d, 10d));

            //// Sử dụng Genric với class :
            ////GenericOfClass<string> genericOfClass = new GenericOfClass<string>();
            //// Or
            //var genericOfClass = new GenericOfClass<string>();
            //genericOfClass.properties = "Đang học Generic trong C# !";
            //Console.WriteLine("- Sử dụng phương thức Display của đối tượng genericOfClass : {0}", genericOfClass.Display());
            #endregion

            #region Làm việc với Collection
            #region 1.Dictionary :
            //Dictionary<string, double> dictionaryProducts = new Dictionary<string, double>()
            //{
            //    {"iphone x" ,  15000000},
            //    {"Oppo 23" , 14000000},
            //    {"ThinkPad Laptop", 23000000}
            //};
            //// Thêm phần tử :
            //dictionaryProducts.Add("Macbook", 23000000);
            //// Duyệt qua các item :
            //Console.WriteLine("- Duyệt qua các phần tử trong Dictionary :");
            //foreach(var item in dictionaryProducts)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //var ketQuaDem = dictionaryProducts.Count();
            //Console.WriteLine("- Số lượng phần tử trong Dictionary là : {0}", ketQuaDem);
            #endregion

            #region 2.HashTable :
            ///*
            // - HashTable lưu trữ tập dữ liệu dưới với mỗi phần tử là một cặp key-value. Có thể truy xuất các phần tử qua
            //key. HashTable hỗ trợ tìm kiếm phần tử qua key rất nhanh , có thể ứng dụng để lưu trữ dữ liệu dưới dạng từ điển.
            // */
            //Hashtable myHashTable = new Hashtable();
            //myHashTable.Add("key01", "Nguyen Van A");
            //myHashTable.Add(1, "Nguyen Van b");
            //myHashTable.Add("key02", "Tran Van C");
            //myHashTable.Add("key03", "Tran Van C");
            //myHashTable.Add("key04", "Tran Van C");
            //myHashTable.Add(true, 12);
            //// Chý ý các key không được trùng nhau . Lỗi.
            //// myHashTable.Add("key01", "Nguyen Van A");
            ////myHashTable.Add(1, "Nguyen Van b");
            ////myHashTable.Add("key02", "Tran Van C");
            ////myHashTable.Add(true, 12);
            //// Duyệt qua các phần tử trong Hashtable :
            //Console.WriteLine("- Duyệt qua các phần tử trong Hashtable : ");
            //foreach(DictionaryEntry item in myHashTable)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}
            //Console.WriteLine("- Số lượng phần tử trong myHashTable là  : {0} ", myHashTable.Count);
            //// Duyệt qua danh sách các key :
            //Console.WriteLine("- Duyệt qua danh sách các key : ");
            //foreach(var item in myHashTable.Keys)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //// Xóa phần tử theo key :
            //myHashTable.Remove(true);
            //// Duyệt qua các phần tử trong Hashtable :
            //Console.WriteLine("- Duyệt qua các phần tử trong Hashtable sau khi xóa : ");
            //foreach (DictionaryEntry item in myHashTable)
            //{
            //    Console.WriteLine($"{item.Key} - {item.Value}");
            //}

            //// Kiểm tra key/value có tồn tại không :
            //Console.WriteLine("- key = 'key01' có tồn tại trong  myHashTable : {0}", myHashTable.ContainsKey("key01"));
            //Console.WriteLine("- key = 'key1' có tồn tại trong  myHashTable : {0}", myHashTable.ContainsKey("key01"));
            //Console.WriteLine("- value = 12 có tồn tại trong  myHashTable : {0}", myHashTable.ContainsValue(12));
            //Console.WriteLine("- value = 'Nguyen Van b' có tồn tại trong  myHashTable : {0}", myHashTable.ContainsValue("Nguyen Van b"));

            #endregion

            #region 3.SortedList :
            ///*
            //- SortedList là một Collection lưu trữ dữ liệu dưới dạng các cập key-value .
            //- SortedList là sự kết hợp giữa ArrayList và HashTable . Các phần tử được sắp xếp
            //keo key. Có thể truy xuất phần tử thông qua key giống HashTable và index giống ArrayList.
            // */
            //SortedList mySortedList = new SortedList();
            //mySortedList.Add("key01", new List<int> {  1, 2 , 3 });
            //mySortedList.Add("key02", true);
            ////mySortedList.Add("key02", true); // Lỗi (System.ArgumentException: 'Item has already ....) key không được trùng nhau !
            ////mySortedList.Add(true, true);    // Lỗi(System.InvalidOperationException: ....) kiểu dữ liệu key phải giống nhau !
            //mySortedList.Add("key03", true);
            //mySortedList.Add("key04", true);
            //mySortedList.Add("key05", "Nguyen Van C");

            //// Duyệt qua SortedList :
            //Console.WriteLine("- Duyệt qua các phần tử trên mySortedList (bằng for): ");
            //for(int i = 0; i < mySortedList.Count; i++)
            //{
            //    Console.WriteLine("{0} \t {1}", mySortedList.GetKey(i) , mySortedList.GetByIndex(i));
            //}

            //// Duyệt bằng foreach :
            //Console.WriteLine("\n- Duyệt qua các phần tử trên mySortedList (bằng foreach): ");
            //foreach(DictionaryEntry item in mySortedList)
            //{
            //    Console.WriteLine(item.Key + "\t" + item.Value);
            //}

            ////  Duyệt qua danh sách các key / value :
            //Console.WriteLine("\n- Lấy danh sách các keys :");
            //foreach(var item in mySortedList.Keys)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            //Console.WriteLine("\n- Lấy danh sách các values :");
            //foreach (var item in mySortedList.Values)
            //{
            //    Console.WriteLine("{0}", item);
            //}

            //// Thay thế giá trị phần tử tại vị trí index :
            //mySortedList.SetByIndex(2, "Vị trí 02 đã vị thay thế !");
            //// Duyệt qua SortedList :
            //Console.WriteLine("- Duyệt qua các phần tử trên mySortedList (bằng for) sau khi thay thế giá trị tại vị trí 2 : ");
            //for (int i = 0; i < mySortedList.Count; i++)
            //{
            //    Console.WriteLine("{0} \t {1}", mySortedList.GetKey(i), mySortedList.GetByIndex(i));
            //}


            //// Kiểm tra key/value có tồn tại :
            //Console.WriteLine("- Kiểm tra key/value có tồn tại trong mySortList : ");
            //Console.WriteLine("key = 'key01' có tồn tại trong mySortedList : {0}", mySortedList.ContainsKey("key01"));
            //Console.WriteLine("key = 'key02' có tồn tại trong mySortedList : {0}", mySortedList.ContainsKey("key02"));
            //Console.WriteLine("key = 'keydemo' có tồn tại trong mySortedList : {0}", mySortedList.ContainsKey("keydemo"));
            //Console.WriteLine("key = 'keycheck' có tồn tại trong mySortedList : {0}", mySortedList.ContainsKey("keycheck"));
            //Console.WriteLine("value = 'key01' có tồn tại trong mySortedList : {0}", mySortedList.ContainsValue("key01"));
            //Console.WriteLine("value = 'key02' có tồn tại trong mySortedList : {0}", mySortedList.ContainsValue("key02"));
            //Console.WriteLine("value = 'Nguyen Van C' có tồn tại trong mySortedList : {0}", mySortedList.ContainsValue("Nguyen Van C"));
            //Console.WriteLine("value = true có tồn tại trong mySortedList : {0}", mySortedList.ContainsValue(true));
            #endregion

            #region 4.Stack :
            ///*
            // - Stack là một Collection lưu trữ dưới dạng key-value. Stack hay còn gọi là ngắn xếp 
            //là một cấu trức dữ liệu hoạt động theo nguyên lý LIFO (Last In First Out) vào sau ra trước.
            //Nghĩa là phần tử vào sau sẽ được sắp lên trên , khi lấy ra sẽ lấy phần tử trên cùng ra. 
            // */
            //Stack myStack = new Stack();
            //myStack.Push(1);
            //myStack.Push(true);
            //myStack.Push("Phần tử");
            //myStack.Push(3.14);
            //myStack.Push(new List<int>{ 1 , 2 , 3 , 4 });

            //// Duyệt qua các phần tử trên Stack :
            //foreach(var item in myStack)
            //{
            //    Console.WriteLine("{0}", item);
            //}
            //Console.WriteLine("- Số lượng phần tử trên myStack : {0}", myStack.Count);

            //myStack.Pop();

            //// Duyệt qua các phần tử trên Stack sau khi Pop():
            //foreach (var item in myStack)
            //{
            //    Console.WriteLine("{0}", item);
            //}
            //Console.WriteLine("- Số lượng phần tử trên myStack : {0}", myStack.Count);
            //#endregion
            #endregion

            #region 5.Queue :
            ///*
            // - Queue là mộ Collection trong C# lưu trữ dữ liệu dưới dạng key-value .
            //- Queue hay còn gọi là hàng đợi là một cấu trúc dữ liệu hoạt động theo nguyên lý
            //FIFO (First In First Out) vào trước ra trước. Nghĩa là phần tử nào vào sau sẽ được 
            //sắp sếp phía dưới , khi lấy ra sẽ lấy phần tử phía trên.
            // */
            //Queue myQueue = new Queue();
            //myQueue.Enqueue("hello");
            //myQueue.Enqueue(3.14);
            //myQueue.Enqueue(3);
            //myQueue.Enqueue(true);
            //myQueue.Enqueue(new List<string>() { "mytring01" , "mystring02" , "mystring03"});

            //// Duyệt qua các phần tử trên myQueue :
            //Console.WriteLine("- Duyệt qua các phần tử trên myQueue : ");
            //foreach(var item in myQueue)
            //{
            //    Console.WriteLine("{0}", item);
            //}
            //Console.WriteLine("- Số lượng phần tử trên myQueue : {0}", myQueue.Count);
            //// Xóa phần tử :
            //myQueue.Dequeue();
            //myQueue.Dequeue();
            //// Duyệt qua các phần tử trên myQueue sau khi xóa Dequeue:
            //Console.WriteLine("\n- Duyệt qua các phần tử trên myQueue sau khi xóa Dequeue : ");
            //foreach (var item in myQueue)
            //{
            //    Console.WriteLine("{0}", item);
            //}
            //Console.WriteLine("- Số lượng phần tử trên myQueue : {0}", myQueue.Count);
            #endregion
            #endregion
        }
    }
}
