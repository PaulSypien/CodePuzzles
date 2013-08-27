using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Project Euler Problem 6 - Sum Square Difference
    /// </summary>
    /// The sum of the squares of the first ten natural numbers is,
    /// 12 + 22 + ... + 102 = 385
    /// The square of the sum of the first ten natural numbers is,
    /// (1 + 2 + ... + 10)^2 = 552 = 3025
    /// Hence the difference between the sum of the squares of the first ten 
    /// natural numbers and the square of the sum is 3025 − 385 = 2640.
    /// Find the difference between the sum of the squares of the first one 
    /// hundred natural numbers and the square of the sum.   
    /// http://projecteuler.net/problem=6 8.26.2013

    public static class SumSquare
    {
        public static double Run()
        {          
            double squareSum = 0;
            double sum = 0;
            for (double x = 1; x <= 100 ; x++)
            {
                squareSum += Math.Pow(x,2);
                sum = sum + x;
            }
            double Finish = ((Math.Pow(sum, 2)) - squareSum);
            
            Console.WriteLine(Finish);
            return Finish;
        }
    }
}
