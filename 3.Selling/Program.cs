using System;

namespace _3.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] matrix = new char[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            int money = 0;
            int currRow = 0;
            int currCol = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j]=='S')
                    {
                        currRow = i;
                        currCol = j;
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                matrix[currRow][currCol] = '-';
                switch (command)
                {
                    case "up":
                        currRow--;
                        break;
                    case "down":
                        currRow++;
                        break;
                    case "left":
                        currCol--;
                        break;
                    case "right":
                        currCol++;
                        break;
                    default:
                        break;
                }
                if (currCol>=size||currCol<0||
                    currRow>=size||currRow<0)
                {
                    break;
                }
                switch (matrix[currRow][currCol])
                {
                    case '-':
                        break;
                    case 'O':
                        for (int i = 0; i < size; i++)
                        {
                            for (int j = 0; j < size; j++)
                            {
                                if (matrix[i][j]=='O'&&i!=currRow&&j!=currCol)
                                {
                                    matrix[currRow][currCol] = '-';
                                    currRow = i;
                                    currCol = j;
                                }
                            }
                        }
                        break;
                    default:
                        money += matrix[currRow][currCol] - 48;
                        break;
                }
                matrix[currRow][currCol] = 'S';
                if (money>=50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    Console.WriteLine($"Money: {money}");
                    for (int i = 0; i < size; i++)
                    {
                        Console.WriteLine(string.Join("",matrix[i]));
                    }
                    return;
                }
            }
            Console.WriteLine("Bad news, you are out of the bakery.");
            Console.WriteLine($"Money: {money}");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }
}
