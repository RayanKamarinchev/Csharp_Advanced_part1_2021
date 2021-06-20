using System;
using System.Linq;

namespace _04.Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = ReadArray();
            int row = int.Parse(arr[0]);
            int col = int.Parse(arr[1]);
            string[,] matrix = ReadMatrix(row, col);
            string[] command = Console.ReadLine().Split();
            while (command[0]!="END")
            {
                if (command[0]=="swap"&&int.Parse(command[1])<row &&
                    int.Parse(command[2]) < col && int.Parse(command[3]) < row&& int.Parse(command[4]) < col)
                {
                    matrix = Swap(matrix, int.Parse(command[1]), int.Parse(command[2]),
                        int.Parse(command[3]), int.Parse(command[4]));
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(matrix[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                command = Console.ReadLine().Split();
            }
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
        static string[,] Swap(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string n = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = n;
            return matrix;
        }
    }
}
