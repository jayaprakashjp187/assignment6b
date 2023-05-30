using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6
{
    internal class MonthleyPayment
    {
        public static double CalculateMonthlyPayment(double a, double b, double c)
        {

            double n = 12 * b;


            double r = c / (12 * 100);


            double payment = (a * r) / (1 - Math.Pow(1 + r, -n));

            return payment;
        }
    }
}
