using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Buoi02Common.Integer
{
    public class CheckInput
    {
        public static int IntegerValue(string inputStringOfInteger , out bool isChecked)
        {
            if (inputStringOfInteger.Length == 0) {
                isChecked = false;
                return -1;
            }
            if (inputStringOfInteger == null){
                isChecked = false;
                return -2;
            }
            int integerOfOutput;
            bool isResult = int.TryParse(inputStringOfInteger, out integerOfOutput);
            if(!isResult){
                isChecked = false;
                return -3;
            }
            isChecked = true;
            return integerOfOutput;
        }
    }
}
