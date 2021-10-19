using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Prime
    {
        public int? CheckPrime(int n)
        {
            // flag is the predefined variable whcih will enable us to terminate the process in case it is divisible by a number
            int count = 1;
            int flag = 0;

            while (count <= n/2)                //chechking the prime number
            {
                count++;

                if (n % count == 0)
                {
                    flag++;
                    break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag > 0)
            {
                Console.WriteLine("The entered number is not a prime number");

            }
            else
            {
                Console.WriteLine("The entered number is a Prime Number");
            }

            return null;
        }
    }
}
