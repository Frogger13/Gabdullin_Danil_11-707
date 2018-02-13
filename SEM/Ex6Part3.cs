using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, num1, num2;
            bool output = true;
            n = int.Parse(Console.ReadLine());
            num1 = int.Parse(Console.ReadLine());
            for (i = 1; i <= (n-1); i++)
            {
                num2 = num1;
                num1 = int.Parse(Console.ReadLine());
                if (num1 < num2)
                {
                    output = false;
                }

            }
            if (output == false) Console.WriteLine("Не возростающая");
            else Console.WriteLine("Возрастающая");
        }
    }
}
