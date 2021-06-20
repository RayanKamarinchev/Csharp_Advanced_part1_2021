using System;
using System.Linq;

namespace _05.MaxSumSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = ReadArray();
            int[,] matrix = ReadMatrix(demensions[0],demensions[1]);
            int maxSum = int.MinValue;
            int maxRow = 0;
            int MaxCol = 0;
            for (int row = 0; row < demensions[0]-1; row++)
            {
                for (int col = 0; col < demensions[1]-1; col++)
                {
                    int sum = matrix[row, col] + 
                        matrix[row, col + 1] + 
                        matrix[row + 1, col] + 
                        matrix[row + 1, col + 1];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        MaxCol = col;
                    }
                }
            }
            Console.WriteLine(matrix[maxRow,MaxCol]+" "+ matrix[maxRow,MaxCol+1]);
            Console.WriteLine(matrix[maxRow+1,MaxCol]+" "+ matrix[maxRow+1,MaxCol+1]);
            Console.WriteLine(maxSum);

        }
        static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new string[] {" ",", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
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
