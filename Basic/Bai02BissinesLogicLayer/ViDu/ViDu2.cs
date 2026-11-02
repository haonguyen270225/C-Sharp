using Buoi02Common.Integer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai02BissinesLogicLayer.ViDu
{
    // Ví dụ 02 : Sử dụng cấu trúc while . Nhập một số nguyên không âm
    // nếu là số âm hoặc không hợp lệ thì yêu cầu nhập lại.
    public class ViDu2
    {
        public static int NhapSoNguyenKhongAm(string integerInputTypeString)
        {
            bool isChecked;
            int valueChecked = CheckInput.IntegerValue(integerInputTypeString, out isChecked);
            if (isChecked == false)
            {
                if (valueChecked == -1) return -1;
                else if (valueChecked == -2) return -2;
                else  return -3;
            }
            else {
                if (valueChecked < 0) return -4;
                else return valueChecked;
            }
        }
    }
}
