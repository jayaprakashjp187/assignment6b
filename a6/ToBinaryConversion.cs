using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a6
{
    internal class ToBinaryConversion
    {
       
            public static string ToBinary(int num)
            {
                string binary = "";

                while (num > 0)
                {
                    binary = (num % 2) + binary;
                    num = num / 2;
                }
                
                return binary;
            }

        

    }
}