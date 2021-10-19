using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        /// <summary>
        /// Calculates the perfect.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int? CalcPerfect(int n)
        {
         
            //local variable declaration
            int sum = 0;
            int num = 1;

            while (num <= n/2)
            {
                if(n % num == 0)
                {
                    sum = sum + num;             //adding the factor to the sum
                }

                num++;       
            }

            if (sum == n )
            {
                Console.WriteLine("The entered number is a Perfect Number!!");
            }
            else
            {
                Console.WriteLine("the entered number isn't a Perfect Number");
            }

            return null;
        }
    }
}
