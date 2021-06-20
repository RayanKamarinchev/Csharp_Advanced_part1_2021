using System;

namespace _02.SquaresMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr= ReadArray();
            int row = int.Parse(arr[0]);
            int col = int.Parse(arr[1]);
            string[,] matrix = ReadMatrix(row,col);
            int squares = 0;
            for (int i = 0; i < row-1; i++)
            {
                for (int j = 0; j < col-1; j++)
                {
                    if (matrix[i,j]==matrix[i+1,j]&&matrix[i,j+1]==matrix[i+1,j+1]&&matrix[i,j]==matrix[i+1,j+1])
                    {
                        squares++;
                    }
                }
            }
            Console.WriteLine(squares);
        }
        static string[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
        }
        static string[,] ReadMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] arrRow = ReadArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrRow[col];
                }
            }
            return matrix;
        }
    }
}
