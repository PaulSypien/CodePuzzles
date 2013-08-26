using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Classic FizzBuzz Problem
    /// </summary>
    /// You are to write a program that must fulfill these simple requirements:
    /// For the numbers from 1 to 100,
    /// If the number is a multiple of 3, print fizz instead of the number.
    /// If the number is a multiple of 5, print buzz instead of the number.
    /// If the number is a multiple of 3 and 5, print fizzbuzz instead of the number.
    /// Otherwise, print the number itself.
    /// Each output should be followed by a new line. 8.23.2013

    public static class FizzBuzz
    {
        public static void Run()
        {
            int y;
            for (y = 1; y <= 100; y++)
            {
                if ((y % 3 == 0) && (y % 5 != 0))
                {
                    System.Console.WriteLine("fizz");
                }
                else if ((y % 5 == 0) && (y % 3 != 0))
                {
                    System.Console.WriteLine("buzz");
                }
                else if ((y % 5 == 0) && (y % 3 == 0))
                {
                    System.Console.WriteLine("fizz buzz");
                }
                else
                {
                    System.Console.WriteLine(y);
                }
            }
  
        }
    }
}
