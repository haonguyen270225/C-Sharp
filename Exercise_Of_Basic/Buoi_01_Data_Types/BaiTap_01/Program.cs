using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Bài tập 01 : Giải phương trình bặc 2 có dạng ax^2 + bx + c = 0 (a != 0).
// Test Case :
/* TEST CASE - CHUONG TRINH GIAI PHUONG TRINH BAC HAI
Phuong trinh: ax ^ 2 + bx + c = 0

============================================================
LOAI 1: DU LIEU SO HOP LE (SO NGUYEN VA SO THUC)
============================================================

Cong thuc:
  Delta = b^2 - 4ac
  Delta > 0: Hai nghiem thuc phan biet
  Delta = 0: Nghiem kep
  Delta < 0: Vo nghiem thuc

STT | a       | b       | c       | KET QUA MONG DOI
----|---------|---------|---------|-----------------------------------------
 1  | 1       | -3      | 2       | x1 = 2, x2 = 1
 2  | 1       | 2       | 1       | Nghiem kep x = -1
 3  | 1       | 1       | 1       | Vo nghiem thuc
 4  | 1       | 0       | -4      | x1 = 2, x2 = -2
 5  | 2       | -5      | 2       | x1 = 2, x2 = 0.5
 6  | 0.5     | -2.5    | 3       | x1 = 3, x2 = 2
 7  | 1       | 0       | 0       | Nghiem kep x = 0
 8  | 1       | 0       | 4       | Vo nghiem thuc
 9  | 2       | 0       | -8      | x1 = 2, x2 = -2
10  | 0.25    | -1.5    | 2       | Nghiem kep x = 3
11  | -1      | 3       | -2      | x1 = 2, x2 = 1
12  | 1.5     | -5      | 2       | x1 ~= 2.8685, x2 ~= 0.4648

CAC TRUONG HOP BIEN:
STT | a       | b       | c       | KET QUA MONG DOI
----|---------|---------|---------|-----------------------------------------
13  | 0       | 2       | -4      | Phuong trinh bac nhat, x = 2
14  | 0       | 0       | 5       | Vo nghiem
15  | 0       | 0       | 0       | Vo so nghiem
16  | 0       | 5       | 0       | Nghiem x = 0
17  | 0.001   | 1       | 0.001   | Hai nghiem thuc phan biet
18  | 1       | 100000  | 1       | Hai nghiem thuc; mot nghiem gan 0

============================================================
LOAI 2: DU LIEU KHONG HOP LE (CO CHU/KY TU DAC BIET/THIEU DU LIEU)
============================================================

STT | a       | b       | c       | KET QUA MONG DOI
----|---------|---------|---------|-----------------------------------------
 1  | abc     | 2       | 1       | Bao loi du lieu cua a
 2  | 1       | hello   | 2       | Bao loi du lieu cua b
 3  | 1       | 2       | xyz     | Bao loi du lieu cua c
 4  | abc     | hello   | xyz     | Tu choi du lieu khong hop le
 5  | 12a     | 2       | 1       | Tu choi chuoi khong phai so
 6  | 1.2.3   | 2       | 1       | Tu choi dinh dang so thuc sai
 7  | @#$     | 2       | 1       | Tu choi ky tu dac biet
 8  | (rong)  | 2       | 1       | Yeu cau nhap lai a
 9  | 1       | (rong)  | 1       | Yeu cau nhap lai b
10  | 1       | 2       | (rong)  | Yeu cau nhap lai c
11  | 1 2     | 2       | 1       | Tu choi nhieu gia tri trong mot truong
12  | --1     | 2       | 1       | Tu choi dinh dang so sai

GHI CHU:
- Khi a = 0, phuong trinh khong con la phuong trinh bac hai; can xu ly rieng.
- Nen dung double.TryParse() de kiem tra dau vao, tranh FormatException.
- Voi so thuc, nen so sanh ket qua voi sai so cho phep (vi du 1e-6).
- Ket qua test co the phu thuoc vao quy uoc dau thap phan cua he thong (dau cham hay dau phay).
"""
*/

/*
 => Các bước giải như sau :
 Bước 1 : Tính delta 
            delta = b^2 - 4*a*c;
 Bước 2 : Kiểmn tra delta :
        + Nếu delta < 0 => Phương trình vô nghiệm
        + Nếu delta = 0 => Phương trình có 1 nghiệm kép -b / 2*a;
        + Nếu delta > 0 => Phương trình có 2 ngiệm phân biệt 
                x1 = (-b - sqrt(delta)) / 2*a
                x2 = (-b + sqrt(delta)) / 2*a
 */
namespace BaiTap_01
{

    internal class Program
    {
        // Mỗi dòng gồm: a, b, c
        static double[,] testCases =
        {
            { 1, -3, 2 },
            { 1,  2, 1 },
            { 1,  1, 1 },
            { 1,  0, -4 },
            { 2, -5, 2 },
            { 0.5, -2.5, 3 },
            { 1,  0, 0 },
            { 1,  0, 4 },
            { 2,  0, -8 },
            { 0.25, -1.5, 2 },
            { -1, 3, -2 },
            { 1.5, -5, 2 },

            // Các trường hợp biên
            { 0, 2, -4 },
            { 0, 0, 5 },
            { 0, 0, 0 },
            { 0, 5, 0 },
            { 0.001, 1, 0.001 },
            { 1, 100000, 1 }
        };
        static string[,] invalidTestCases =
        {
            { "abc", "2", "1" },
            { "1", "hello", "2" },
            { "1", "2", "xyz" },
            { "abc", "hello", "xyz" },
            { "12a", "2", "1" },
            { "1.2.3", "2", "1" },
            { "@#$", "2", "1" },
            { "", "2", "1" },
            { "1", "", "1" },
            { "1", "2", "" },
            { "1 2", "2", "1" },
            { "--1", "2", "1" }
        };
        static void GiaiPhuongTrinhBacHai(double a, double b, double c)
        {
            // Kiểm tra điều kiện a != 0
            if (a == 0)
            {
                Console.WriteLine("- Phương trình không hợp lệ (a phải != 0)!");
                return;
            }
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine($"- Phương trình vô nghiệm ! {delta} < 0");
            }
            else if (delta == 0)
            {
                double xNgiemKep = -b / (2 * a);
                Console.WriteLine($"- Phương trình có nghiệm kép ! {delta} == 0" + $"\n x1 = x2 = {xNgiemKep}");            // {x:F2} để in ra  2 chữ số thập phân cuối or {x:0.##}
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"- Phương trình có hai nghiệm phân biệt ! {delta} > 0" + $"\n X1 = {x1}" + $"\n X2 = {x2}");
            }
        }

        static bool CheckOfInputOfString(string stringOfInputA, string stringOfInputB, string stringOfInputC)
        {
            bool valida = double.TryParse(stringOfInputA, out double a);
            bool validb = double.TryParse(stringOfInputB, out double b);
            bool validc = double.TryParse(stringOfInputC, out double c);

            bool isResult = (valida && validb && validc);
            if (isResult == false)
            {
                if (valida == false)
                {
                    Console.WriteLine("- Tham số a không hợp lệ !");
                }
                if (validb == false)
                {
                    Console.WriteLine("- Tham số b không hợp lệ !");
                }
                if (validc == false)
                {
                    Console.WriteLine("- Tham số c không hợp lệ !");
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //GiaiPhuongTrinhBacHai(4, -2, -6);
            //GiaiPhuongTrinhBacHai(1, -49, -50);
            //GiaiPhuongTrinhBacHai(2, -7, 3);

            // Thử nghiệm test invalidTestCases[,] :
            Console.WriteLine("============== Thử nghiệm test invalidTestCases[,] : ================= ");
            for (int i = 0; i < invalidTestCases.GetLength(0); i++)
            {
                Console.WriteLine($"\nTest case {i + 1}:");
                string inputTypeStringA = invalidTestCases[i, 0].ToString();
                string inputTypeStringB = invalidTestCases[i, 1].ToString();
                string inputTypeStringC = invalidTestCases[i, 2].ToString();

                if (CheckOfInputOfString(inputTypeStringA, inputTypeStringB, inputTypeStringC))
                {
                    double a = Convert.ToDouble(inputTypeStringA);
                    double b = Convert.ToDouble(inputTypeStringB);
                    double c = Convert.ToDouble(inputTypeStringC);
                    GiaiPhuongTrinhBacHai(a, b, c);
                }
            }

            // Thử nghiệm test testCases[,] :
            Console.WriteLine("============== Thử nghiệm test testCases[,] : ================= ");
            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                Console.WriteLine($"\nTest case {i + 1}:");
                double a = Convert.ToDouble(testCases[i , 0]);
                double b = Convert.ToDouble(testCases[i, 1]);
                double c = Convert.ToDouble(testCases[i, 2]);

                GiaiPhuongTrinhBacHai(a, b, c);
            }
        }
    }
}
