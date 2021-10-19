using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable which is going to be the argument for the test cases
            int argument;

            Console.WriteLine(" ** Welcome to the Logical Programs ** ");
            Console.WriteLine();
            Console.WriteLine("Enter the number to select the following programs:");
            Console.WriteLine();
            Console.WriteLine("1 -Fibonacci, 2- Perfect Number checker, 3- Prime Number checker, 4- Reverse Num");
            Console.WriteLine("5- Stopwatch Simulator, 6- Coupon generator");
            Console.WriteLine();

            //Taking the user input and converting it to int 
            int num = Convert.ToInt32(Console.ReadLine());     //taking the switch case input

            //switching through the various cases
            switch (num)
            {
            //bewlow cases concludes an object that is created with the respective class of that program. Then the class methods are sued to obtain the information.
                case 1:
                    Console.WriteLine("You have selected the Fibonacci program. Enter the the number of nth number");
                    argument = Convert.ToInt32(Console.ReadLine());
                    Fibonacci myobj1 = new Fibonacci();
                    Console.WriteLine(myobj1.CalcFibonacci(argument));
                    break;


                case 2:
                    Console.WriteLine("You have selected the Perfect number program. Enter your Number");
                    argument = Convert.ToInt32(Console.ReadLine());
                    PerfectNumber myobj2 = new PerfectNumber();
                    Console.WriteLine(myobj2.CalcPerfect(argument));
                    break;

                case 3:
                    Console.WriteLine("You have selected the Prime number checker program. Enter your number");
                    argument = Convert.ToInt32(Console.ReadLine());
                    Prime myobj3 = new Prime();
                    Console.WriteLine(myobj3.CheckPrime(argument));
                    break;

                case 4:
                    Console.WriteLine("You have selected the Reversing your number program. Please enter your number.");
                    argument = Convert.ToInt32(Console.ReadLine());
                    ReverseNum myobj4 = new ReverseNum();
                    Console.WriteLine(myobj4.RevNum(argument));
                    break;

                case 5:
                    Console.WriteLine("You have selected the Stopwatch Program.");
                    Console.WriteLine();
                    StopwatchSimulator myobj5 = new StopwatchSimulator();
                    myobj5.timer();
                    break;

                case 6:
                    Console.WriteLine("You have selected the Coupon number program. Please enter how many coupon numbers u have.");
                    argument = Convert.ToInt32(Console.ReadLine());
                    CouponNumbers myobj6 = new CouponNumbers();
                    Console.WriteLine(myobj6.CheckCoupon(argument));
                    break;

                default:
                    Console.WriteLine("Enter valid option ");
                    break;
                  
            }
            Console.ReadLine();
        }
    }
}

