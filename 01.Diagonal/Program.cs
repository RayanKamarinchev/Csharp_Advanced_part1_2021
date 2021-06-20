using System;
using System.Linq;

namespace _01.Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n,n);
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                sum1 += matrix[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                sum2 += matrix[i, n - i-1];
            }
            Console.WriteLine(Math.Abs(sum1-sum2));
        }

        static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arrRow = ReadArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrRow[col];
                }
            }
            return matrix;
        }
    }
}
