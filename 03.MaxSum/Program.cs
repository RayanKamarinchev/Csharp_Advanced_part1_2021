using System;
using System.Linq;

namespace _03.MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ReadArray();
            int row = arr[0];
            int col = arr[1];
            int[,] matrix = ReadMatrix(row, col);
            int maxSum = int.MinValue;
            int sum = 0;
            int[] maxIndex = {0, 0};
            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    sum += matrix[i, j];
                    sum += matrix[i, j+1];
                    sum += matrix[i, j+2];
                    sum += matrix[i+1, j];
                    sum += matrix[i+1, j+1];
                    sum += matrix[i+1, j+2];
                    sum += matrix[i+2, j];
                    sum += matrix[i+2, j+1];
                    sum += matrix[i+2, j+2];
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxIndex[0] = i;
                        maxIndex[1] = j;
                    }
                    sum = 0;
                }
            }
            int maxRow = maxIndex[0];
            int maxCol = maxIndex[1];
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol+1]} {matrix[maxRow, maxCol+2]}");
            Console.WriteLine($"{matrix[maxRow+1,maxCol]} {matrix[maxRow+1, maxCol+1]} {matrix[maxRow+1, maxCol+2]}");
            Console.WriteLine($"{matrix[maxRow+2,maxCol]} {matrix[maxRow+2, maxCol+1]} {matrix[maxRow+2, maxCol+2]}");
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
