using System;
using System.Collections.Generic;

namespace _02.Mario
{
    public class Program
    {
        static void Main(string[] args)
        {
            int helth = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            const char MARIO = 'M';
            const char PRINCES = 'P';
            const char BOWSER = 'B';
            char[][] matrix = new char[x][];
            for (int i = 0; i < x; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }
            Dictionary<string, int> marioLocation = FindCharacter(matrix, MARIO);
            Dictionary<string, int> princesLocation = FindCharacter(matrix, PRINCES);
            while (true)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                matrix[int.Parse(command[1])][int.Parse(command[2])] = BOWSER;
                helth--;
                switch (command[0])
                {
                    case "W":
                        if (marioLocation["row"] - 1 < 0)
                        {
                            continue;
                        }
                        matrix[marioLocation["row"]][marioLocation["col"]] = '-';
                        marioLocation["row"]--;
                        break;
                    case "A":
                        if (marioLocation["col"] - 1 < 0)
                        {
                            continue;
                        }
                        matrix[marioLocation["row"]][marioLocation["col"]] = '-';
                        marioLocation["col"]--;
                        break;
                    case "D":
                        if (marioLocation["col"] + 1 == matrix[marioLocation["row"]].Length)
                        {
                            continue;
                        }
                        matrix[marioLocation["row"]][marioLocation["col"]] = '-';
                        marioLocation["col"]++;
                        break;
                    case "S":
                        if (marioLocation["row"] + 1 == matrix[marioLocation["row"]].Length)
                        {
                            continue;
                        }
                        matrix[marioLocation["row"]][marioLocation["col"]] = '-';
                        marioLocation["row"]++;
                        break;
                    default:
                        break;
                }
                if (helth <= 0)
                {
                    matrix[marioLocation["row"]][marioLocation["col"]] = 'X';
                    Console.WriteLine($"Mario died at {marioLocation["row"]};{marioLocation["col"]}.");
                    break;
                }
                if (matrix[marioLocation["row"]][marioLocation["col"]]=='B')
                {
                    helth-=2;
                    if (helth <= 0)
                    {
                        matrix[marioLocation["row"]][marioLocation["col"]] = 'X';
                        Console.WriteLine($"Mario died at {marioLocation["row"]};{marioLocation["col"]}.");
                        break;
                    }
                }
                matrix[marioLocation["row"]][marioLocation["col"]] = 'M';
                if (princesLocation["row"] == marioLocation["row"] &&
                    princesLocation["col"] == marioLocation["col"])
                {
                    matrix[marioLocation["row"]][marioLocation["col"]] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {helth}");
                    break;
                }
                matrix[marioLocation["row"]][marioLocation["col"]] = 'M';
                //for (int i = 0; i < x; i++)
                //{
                //    Console.WriteLine(string.Join("", matrix[i]));
                //}
            }
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }

        static Dictionary<string, int> FindCharacter(char[][] matrix, char character)
        {
            int size = matrix.Length;
            bool isFound=false;
            Dictionary<string, int> location = new Dictionary<string, int>();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j] == character)
                    {
                        location.Add("row", i);
                        location.Add("col", j);
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            return location;
        }
    }
}
