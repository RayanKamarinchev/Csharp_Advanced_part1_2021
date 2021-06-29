using System;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] beach = new char[size][];
            int playerTokens = 0;
            int opponentTokens = 0;
            for (int i = 0; i < size; i++)
            {
                beach[i] = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0]!="Gong")
            {
                int targetX = int.Parse(command[1]);
                int targetY = int.Parse(command[2]);
                if (command[0] == "Find")
                {
                    if (targetX >= 0 && targetX < size &&
                        targetY >= 0 && targetY < beach[targetX].Length)
                    {
                        if (beach[targetX][targetY] == 'T')
                        {
                            playerTokens++;
                        }
                        beach[targetX][targetY] = '-';
                    }
                }
                else if (command[0] == "Opponent")
                {
                    if (targetX >= 0 && targetX < size &&
                        targetY >= 0 && targetY < beach[targetX].Length)
                    {
                        switch (command[3])
                        {
                            case "up":
                                for (int i = targetX; i >= targetX - 3; i--)
                                {
                                    if (i >= 0 && i < size &&
                                        targetY >= 0 && targetY < beach[i].Length)
                                    {
                                        if (beach[i][targetY] == 'T')
                                        {
                                            opponentTokens++;
                                        }
                                        beach[i][targetY] = '-';
                                    }
                                }
                                break;
                            case "down":
                                for (int i = targetX; i < targetX + 4; i++)
                                {
                                    if (i >= 0 && i < size &&
                                        targetY >= 0 && targetY < beach[i].Length)
                                    {
                                        if (beach[i][targetY] == 'T')
                                        {
                                            opponentTokens++;
                                        }
                                        beach[i][targetY] = '-';
                                    }
                                }
                                break;
                            case "left":
                                for (int i = targetY; i >= targetY - 3; i--)
                                {
                                    if (targetX >= 0 && targetX < size &&
                                        i >= 0 && i < beach[targetX].Length)
                                    {
                                        if (beach[targetX][i] == 'T')
                                        {
                                            opponentTokens++;
                                        }
                                        beach[targetX][i] = '-';
                                    }
                                }
                                break;
                            case "right":
                                for (int i = targetY; i < targetY + 4; i++)
                                {
                                    if (targetX >= 0 && targetX < size &&
                                        i >= 0 && i < beach[targetX].Length)
                                    {
                                        if (beach[targetX][i] == 'T')
                                        {
                                            opponentTokens++;
                                        }
                                        beach[targetX][i] = '-';
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(string.Join(" ",beach[i]));
            }
            Console.WriteLine($"Collected tokens: {playerTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");
        }
    }
}
