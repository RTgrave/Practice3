using System.Reflection.Emit;
using System.Data;
using System.Text.RegularExpressions;
using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Programm
    {
        static void Main(string[] args)
        {
            double x = 0;
            Console.ToDouble(Console.ReadLine(x));
            int n = 0;
            Console.ToDouble(Console.ReadLine(n));
            for (int i = 1; i <= n; i++)
            {
                x= x - (Match.Pow(x, i)/i);
                x= x + (Match.Pow(x, [i+1])/[i+1]);
                Console.ToDouble(Console.ReadLine(x));
            }
        }
    }
}