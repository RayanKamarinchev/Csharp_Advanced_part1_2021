using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.mutantBunny
{
    class Program
    {
        static bool gameOver = false;
        static void Main(string[] args)
        {
            int[] arr = ReadArray();
            int row = arr[0];
            int col = arr[1];
            char[,] matrix = ReadMatrix(row, col);
            string txt=Console.ReadLine();
            Queue<char> moves = new Queue<char>();
            int playerRow = 0;
            int playerCol = 0;
            foreach (char move in txt)
            {
                moves.Enqueue(move);
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i,j]=='P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            while (moves.Count>0)
            {
                switch (moves.Peek())
                {
                    case 'U':
                        matrix[playerRow, playerCol] = '.';
                        playerRow--;
                        break;
                    case 'L':
                        matrix[playerRow, playerCol] = '.';
                        playerCol--;
                        break;
                    case 'R':
                        matrix[playerRow, playerCol] = '.';
                        playerCol++;
                        break;
                    case 'D':
                        matrix[playerRow, playerCol] = '.';
                        playerRow++;
                        break;
                    default:
                        break;
                }
                try
                {
                    if (matrix[playerRow,playerCol]=='B')
                    {
                        gameOver = true;
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    switch (moves.Peek())
                    {
                        case 'U':
                            playerRow++;
                            break;
                        case 'L':
                            playerCol++;
                            break;
                        case 'R':
                            playerCol--;
                            break;
                        case 'D':
                            playerRow--;
                            break;
                        default:
                            break;
                    }
                    matrix = GrowBunnies(matrix);
                    break;
                }
                matrix = GrowBunnies(matrix);
                if (gameOver)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(matrix[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;
                }
                moves.Dequeue();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"won: {playerRow} {playerCol}");
        }

        static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] arrRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arrRow[col];
                }
            }
            return matrix;
        }
        static char[,] GrowBunnies(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j]=='B')
                    {
                        try
                        {
                            if (matrix[i - 1, j] == 'P')
                            {
                                gameOver = true;
                            }
                            matrix[i - 1, j] = 'A';
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                        try
                        {
                            if (matrix[i, j - 1] == 'P')
                            {
                                gameOver = true;
                            }
                            matrix[i, j - 1] = 'A';
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                        try
                        {
                            if (matrix[i, j + 1] == 'P')
                            {
                                gameOver = true;
                            }
                            matrix[i, j + 1] = 'A';
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }

                        try
                        {
                            if (matrix[i + 1, j] == 'P')
                            {
                                gameOver = true;
                            }
                            matrix[i + 1, j] = 'A';
                        }
                        catch (IndexOutOfRangeException)
                        {
                        }
                    }
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'A')
                    {
                        matrix[i, j] = 'B';
                    }
                }
            }
            return matrix;
        }
    }
}
