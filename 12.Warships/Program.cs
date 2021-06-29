using System;
using System.Linq;

namespace _12.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            // getting matrix and commands
            int size = int.Parse(Console.ReadLine());
            string[] turnCommand = Console.ReadLine().Split(',');
            int[][] commands = new int[turnCommand.Length][];
            char[][] matrix = new char[size][];
            for (int i = 0; i < turnCommand.Length; i++)
            {
                commands[i] = turnCommand[i].Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            for (int i = 0; i < size; i++)
            {
                //# < * < *
                matrix[i] = Console.ReadLine().Replace(" ","").ToCharArray();
            }
            //get number of ships
            int player1Ships = 0;
            int player2Ships = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j] == '<')
                    {
                        player1Ships++;
                    }
                    else if (matrix[i][j] == '>')
                    {
                        player2Ships++;
                    }
                }
            }
            int destroyedShips = 0;

            // The game
            bool isDraw = true;
            bool isPlayer1Winner = true;
            for (int i = 0; i < commands.GetLength(0); i++)
            {
                int targetX = commands[i][0];
                int targetY = commands[i][1];
                if (0 > targetX || targetX >= size ||
                    0 > targetY || targetY >= size)
                {
                    continue;
                }

                switch (matrix[targetX][targetY])
                {
                    case '<':
                        player1Ships--;
                        destroyedShips++;
                        break;
                    case '>':
                        player2Ships--;
                        destroyedShips++;
                        break;
                    case '#':
                        for (int j = targetX - 1; j < targetX + 2; j++)
                        {
                            if (0 > j || j >= size)
                            {
                                continue;
                            }
                            for (int k = targetY - 1; k < targetY + 2; k++)
                            {
                                if (0 > k || k >= size)
                                {
                                    continue;
                                }

                                if (matrix[j][k] == '<')
                                {
                                    player1Ships--;
                                    destroyedShips++;
                                }
                                else if (matrix[j][k] == '>')
                                {
                                    player2Ships--;
                                    destroyedShips++;
                                }
                                matrix[j][k] = 'X';
                            }
                        }
                        break;
                }
                matrix[targetX][targetY] = 'X';
                if (player1Ships == 0)
                {
                    isPlayer1Winner = false;
                    isDraw = false;
                    break;
                }
                if (player2Ships == 0)
                {
                    isPlayer1Winner = true;
                    isDraw = false;
                    break;
                }
            }

            // Printing the winner
            if (isDraw)
            {
                Console.WriteLine($"It's a draw! Player One has {player1Ships} ships left." +
                    $" Player Two has {player2Ships} ships left.");
            }
            else
            {
                if (isPlayer1Winner)
                {
                    Console.WriteLine($"Player One has won the game!" +
                        $" {destroyedShips} ships have been sunk in the battle.");
                }
                else
                {
                    Console.WriteLine($"Player Two has won the game!" +
                        $" {destroyedShips} ships have been sunk in the battle.");
                }
            }
        }
    }
}
