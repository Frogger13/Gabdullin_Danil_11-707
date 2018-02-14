using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double powed = 1;
            double power=0;
            do
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    a = Math.Abs(a);
                    Console.WriteLine(a);
                }
                else if (a>0)
                {
                    for (double i = 0; powed < a; i++)
                    {
                        powed = Math.Pow(2, i);
                        power = i;
                    }
                     Console.WriteLine(power);
                }
            }

            while (a != 0);

        }
    }
}
