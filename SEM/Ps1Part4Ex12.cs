using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int x, y, z;
            int n = 0;
            for (x=0;x<m;x++)
                for (y=0;y<=m;y++)
                    for (z=0;z<m;z++)
                    {
                        if ((Math.Pow(x, k) % m) == (Math.Pow(y, k) % m) + (Math.Pow(z, k) % m))
                            n++;
                    }
            Console.WriteLine(n);
        }
    }
}
