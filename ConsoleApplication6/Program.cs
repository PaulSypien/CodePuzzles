using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice.FizzBuzz.Run();    //  Classic FizzBuzz
            Mulitples.Run();            //  Project Euler # 1: Sum of all multiples of 3 and 5 below 1000
            Fib.Run();                  //  Project Euler # 2: Sum of even numbers in Fibonacci sequence below 4000000
            LargestPrimeFactor.Run() ;  //  Project Euler # 3: Largest prime factor
            Palindrome.Run();           //  Project Euler # 4: Largest palindrome product
            SumSquare.Run();            //  Project Euler # 6: Sum of squares, squares of sums


            System.Console.ReadLine();
        }
    }
}
