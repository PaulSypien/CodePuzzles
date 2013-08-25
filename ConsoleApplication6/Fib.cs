﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    /// <summary>
    /// Project Euler Problem 2 - Fibonacci
    /// </summary>
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
    /// By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
    /// find the sum of the even-valued terms.
    /// http://projecteuler.net/problem=2 08.25.2013

    public static class Fib
    {
        public static int Run()
    {
        int current = 1;
        int sum = 0;
        int previous = 0;
        int updated = 0;

        while (current <= 4000000)
        {
            updated = previous + current;
            previous = current;
            current = updated;

            if (current%2==0)
            {
                sum = sum + current;
            }
        
        }
        Console.WriteLine(sum);
        return sum;
    }
    }
}
