using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------ First Program ------------------------
            String sum; String tryAgain; int sum2;
            tryAgain = "y";
            while (tryAgain == "y")
            {
                Random rnum = new Random();
                var num1 = rnum.Next(1, 10);
                var num2 = rnum.Next(1, 10);
                Console.Write($"{num1} + {num2} = ");
                sum = Console.ReadLine();
                //Console.WriteLine($"{sum}");
                sum2 = Convert.ToInt32(sum);
                int total = num1 + num2;

                if (total == sum2)
                {
                    Console.WriteLine("You are Correct");
                }
                else
                {
                    Console.WriteLine("You are not correct");
                }
                Console.Write($"Do you want to try again (yes or no)?  ");
                tryAgain = Console.ReadLine();
            }
        }
    }
}
