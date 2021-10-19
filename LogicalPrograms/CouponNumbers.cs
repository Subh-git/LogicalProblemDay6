using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumbers
    {
        
        //declaring static variables at the top
        static int num;
        static int count = 0;                 //this is the counter variable 
        
        // check coupon method
        public int? CheckCoupon(int n)
        {
            while (n >0)
            {
                GenerateCoupon();              // calling the generate coupon method
                n--;                           // decrementing
            }
            Console.WriteLine("The number of Random numbers generated for this purpose is :" +count);
            return null;
        }
        static void GenerateCoupon()
        {
            // this static method takes a number from the user input
            Console.WriteLine("Please enter your distinct 2- digit coupon number");
            num = Convert.ToInt32(Console.ReadLine());            
            // calling out the distinct checker method which takes the input as the user input
            DistinctChecker(num);

        }

        static void DistinctChecker(int number)
        {
            int a=0;
            while (number != a)
            {
                // generating random number and checking it with the predefined user input number
                Random random = new Random();
                 a = random.Next(10, 100);
                count++;                     // incrementing the count variable
            }

        }
    }
}
