using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Fibonacci
    {
        public int CalcFibonacci(int n)
        {          
            if (n <= 1)
            {
                return n;
            }
            else
            { // calling the same function  recursively. and adding the lasst two numbers to obtain the 3rd number.
                // this is decrementing in nature as the value of n decreases
                return CalcFibonacci(n - 1) + CalcFibonacci(n - 2);
            }


        }
    }
}
