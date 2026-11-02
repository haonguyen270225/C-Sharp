using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai02BissinesLogicLayer.ViDu
{
    public class ViDu1
    {
        // Ví dụ 01 : Sử dụng dòng for duyệt qua các số nguyên lẻ từ 1 -> n !
        public static List<int> ViDu01OfDuyetQuaSoLe(int n)
        {
            List<int> listResultOfSoLe = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    listResultOfSoLe.Add(i);
                }
            }
            return listResultOfSoLe;
        }
    }
}
