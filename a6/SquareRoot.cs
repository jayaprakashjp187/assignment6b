using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6
{
    internal class SquareRoot
    {
         public static double FindingSqrt(double c)
        {
            if (c < 0)
            {
                Console.WriteLine("Input must be a non-negative number.");
            }
            double epsilon = 1e-15;
            double value = c;
            while (Math.Abs(value - c / value) > epsilon * value)
            {
                value = (c / value + value) / 2.0;
            }
            return value;
        }
    }
}
