using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class ReverseNum
    {
        public int RevNum(int n)
        {
            //reverse num is thee variable that stores the reverse number
            int reverse = 0;
            int a;

            while (n > 0)
            {
                a = (n % 10);                          //obtaing the last digit in the number by using the remainder operation
                reverse = (reverse * 10) + a;          // multiplying by 10's 100's etc depending upon the digits
                n = n / 10;

            }
            return reverse;
        }
    }
}
