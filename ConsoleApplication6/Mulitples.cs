using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Project Euler Problem 1 - Multiples of 3 and 5
    /// </summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5,
    /// we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// http://projecteuler.net/problem=1 08.24.2013
    
    public static class Mulitples
    {
        public static int Run() 
        {
            int sum = 0;

            for (int A = 0; A < 1000; A++)
            {
                if ((A % 3 == 0) || (A % 5 == 0))
                {
                    sum = sum + A;
                }
            }
            Console.WriteLine(sum);
            return sum;
        }

    }
}
