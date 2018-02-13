using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, a1, a2;
            double sum;
            n = int.Parse(Console.ReadLine());
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            d = a2 - a1;
            sum = (2*a1 + d*(n-1))/2 * n;
            Console.WriteLine(sum);
        }
    }
}
