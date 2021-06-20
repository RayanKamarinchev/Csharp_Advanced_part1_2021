using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ReadArray();
            int row = arr[0];
            int col = arr[1];
            string snake = Console.ReadLine();
            Queue<char> lastSnake = FillSnake(snake);
            char[,] matrix = new char[row,col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (lastSnake.Count==0)
                    {
                        lastSnake = FillSnake(snake);
                    }

                    if (i % 2 == 0)
                    {
                        matrix[i, j] = lastSnake.Dequeue();
                    }
                    else
                    {
                        matrix[i, col - j - 1] = lastSnake.Dequeue();
                    }
                }
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }

        static int[] ReadArray()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        static Queue<char> FillSnake(string snake)
        {
            Queue<char> lastSnake = new Queue<char>();
            for (int i = 0; i < snake.Length; i++)
            {
                lastSnake.Enqueue(snake[i]);
            }
            return lastSnake;
        }
    }
}
