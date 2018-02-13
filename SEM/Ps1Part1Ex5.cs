using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static int[] ReadCoordinates(int[] coordinates)
        {
            for (int i = 0; i < coordinates.Length; i++)
            {
                coordinates[i] = int.Parse(Console.ReadLine());
            }
            return coordinates;
        }


        static bool CheckBoard(int[] coordinates)
        {
            bool check = false;
            foreach (int coord in coordinates)
                if (coord > 0 && coord < 9)
                    check = true;
            return check;
        }

        static bool Neigbour(int[] coordinates)
        {
            if (Math.Abs(coordinates[0] - coordinates[2]) == Math.Abs((coordinates[1] + 1) - coordinates[3]) || (coordinates[0] - coordinates[2]) == Math.Abs((coordinates[1] - 1) - coordinates[3]))
                return true;
            else return false;
        }

        static bool CheckDiagonal(int[] coordinates)
        {
            if (Math.Abs(coordinates[0] - coordinates[2]) == Math.Abs(coordinates[1] - coordinates[3]))
                return true;
            else return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты:первые 2 - x, y первых координат, вторые - вторых ");
            int[] coordinates = new int[4];
            bool check = CheckBoard(coordinates);
            ReadCoordinates(coordinates);
            if (!CheckBoard(coordinates))
                Console.WriteLine("Ввели неправильные координаты");
            else
            {
                if (CheckDiagonal(coordinates))
                    Console.WriteLine("SAME");
                else if (Neigbour(coordinates))
                    Console.WriteLine("NIGHBOUR");
                else Console.WriteLine("Находятся не на соседних не на диагонали");
            }


        }
    }
}
