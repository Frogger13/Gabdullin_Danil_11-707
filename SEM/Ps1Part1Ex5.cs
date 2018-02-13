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
            int[] neighDiagonal1, neighDiagonal2, neighDiagonal3, neighDiagonal4, neighDiagonal5, neighDiagonal6;
            neighDiagonal1 = neighDiagonal2 = neighDiagonal3 = neighDiagonal4 = neighDiagonal5 = neighDiagonal6 = coordinates;
            neighDiagonal1[0]++;
            neighDiagonal2[1]++;
            neighDiagonal3[1]++;
            neighDiagonal3[0]++;
            neighDiagonal4[0]--;
            neighDiagonal5[1]--;
            neighDiagonal6[0]--;
            neighDiagonal6[1]--;
            if (CheckDiagonal(neighDiagonal1) || CheckDiagonal(neighDiagonal2) || CheckDiagonal(neighDiagonal3) || CheckDiagonal(neighDiagonal4) || CheckDiagonal(neighDiagonal5) || CheckDiagonal(neighDiagonal6) )
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
