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
            int year;
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("12.09." + year);
            }
            else Console.WriteLine("13.09." + year);
        }
    }
}
