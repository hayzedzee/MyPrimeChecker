using System;

namespace MyPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("This is a simple prime number checker console application...");
            Console.WriteLine("pls enter your prefered number: ");
           int n = Convert.ToInt32(Console.ReadLine()); 
           int a = 0;
         for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
               a++;
            }
         }
         if (a == 2) {
            Console.WriteLine("{0} is a Prime Number", n);
         } else {
            Console.WriteLine("Not a Prime Number");
         }
        }
    }
}
