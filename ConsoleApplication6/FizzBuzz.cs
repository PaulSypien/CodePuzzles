using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Classic Fizz Buzz Problem
    /// </summary>
    /// 
    ///


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
