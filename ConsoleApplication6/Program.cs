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
            Practice.FizzBuzz.Run();        //Classic FizzBuzz
            int a = Mulitples.Run();        //Project Euler # 1: Sum of all Multiples of 3 and 5 below 1000
            int b = Fib.Run();              //Project Euler # 2: Sum of even numbers in Fibonacci sequence below 4000000
            double f = SumSquare.Run();     //Project Euler # 6: Sum of Squares, Squares of Sums

            System.Console.ReadLine();
        }
    }
}
