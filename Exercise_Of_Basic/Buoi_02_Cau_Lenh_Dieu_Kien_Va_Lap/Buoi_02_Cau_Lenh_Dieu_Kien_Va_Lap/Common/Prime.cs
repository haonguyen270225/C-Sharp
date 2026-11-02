using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Buoi_02_Cau_Lenh_Dieu_Kien_Va_Lap.Common
{
    internal class Prime
    {
        public static bool ISPrime(int number)
        {
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    return false;
                }

            }
            return true;
        }


        // Sang so nguyen to do phuc tap O(n)
        // In ra cac so nguyen to 1->n voi n khong qua 10^6;
        /*
        b1) co tat ca cac phan tu trong mang tu 0 -> n la so nguyen to;
        b2) Loai 0 va 1;
        b3)Neu i la so nguyen to -> Ta duyet qua cac boi cua i va cho no khong la so nguyen to;
        */

        public static int[] prime = new int[1000001];
        public static void Sieve()
        {
            for(int i = 0; i <= 1000000; i++)
            {
                prime[i] = 1;
            }
            // Loại bỏ 0 và 1 :
            prime[0] = prime[1] = 0;
            
            for(int i = 2; i <= Math.Sqrt(1000000); i++)
            {
                if (prime[i] == 1)
                {
                    for(int j = i*i; j <= 1000000; j += i)
                    {
                        prime[j] = 0;
                    }
                }
            }
        }
    }
    
}
