using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.Common
{
    internal class GiaiThua
    {
        public static int ResultOfGiaiThua(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else if (number < 0)
            {
                int tmp = Math.Abs(number);
                int result = 1;
                for (int i = 1; i <= tmp; i++)
                {
                    result *= i;
                }
                return result * (-1);
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
