using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
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
