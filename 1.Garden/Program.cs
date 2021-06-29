using System;
using System.Linq;

namespace _1.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[][] matrix = new int[demensions[0]][];
            for (int i = 0; i < demensions[0]; i++)
            {
                matrix[i] = new int[demensions[1]];
                for (int j = 0; j < demensions[1]; j++)
                {
                    matrix[i][j] = 0;
                }
            }
            string[] command = Console.ReadLine().Split();
            while (command[0]!="Bloom")
            {
                int flowerX = int.Parse(command[0]);
                int flowerY = int.Parse(command[1]);
                if (flowerX >= 0 && flowerX < demensions[0] 
                    && flowerY >= 0 && flowerY < demensions[1])
                {
                    for (int i = 0; i < demensions[0]; i++)
                    {
                        matrix[i][flowerY]++;
                    }
                    for (int i = 0; i < demensions[1]; i++)
                    {
                        matrix[flowerX][i]++;
                    }
                    matrix[flowerX][flowerY]--;
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
                command= Console.ReadLine().Split();
            }
            for (int i = 0; i < demensions[0]; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
