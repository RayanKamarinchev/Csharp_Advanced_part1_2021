using System;

namespace _2.Player
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -F--
            ----
            -f--
            -B--
    
            -B--
            -F--
            ----
            -f--

            *most* down, right
            -f--
            -BF-
            -T--
            ----*/
            int size = int.Parse(Console.ReadLine());
            int moves = int.Parse(Console.ReadLine());
            int playerX = 0;
            int playerY = 0;
            char[][] matrix = new char[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    if (matrix[i][j]=='f')
                    {
                        playerX = i;
                        playerY = j;
                    }
                }
            }

            bool isTheGameLost = true;
            for (int i = 0; i < moves; i++)
            {
                matrix[playerX][playerY] = '-';
                string direction = Console.ReadLine();
                switch (direction)
                {
                    case "up":
                        playerX--;
                        break;
                    case "down":
                        playerX++;
                        break;
                    case "left":
                        playerY--;
                        break;
                    case "right":
                        playerY++;
                        break;
                    default:
                        break;
                }

                if (playerX<0)
                {
                    playerX = size + playerX;
                }
                if (playerY<0)
                {
                    playerY = size + playerY;
                }
                if (playerX >= size)
                {
                    playerX = size - playerX;
                }
                if (playerY >= size)
                {
                    playerY = size - playerY;
                }

                if (matrix[playerX][playerY]=='T')
                {
                    switch (direction)
                    {
                        case "up":
                            playerX++;
                            break;
                        case "down":
                            playerX--;
                            break;
                        case "left":
                            playerY++;
                            break;
                        case "right":
                            playerY--;
                            break;
                        default:
                            break;
                    }
                }
                else if (matrix[playerX][playerY]=='B')
                {
                    switch (direction)
                    {
                        case "up":
                            playerX--;
                            break;
                        case "down":
                            playerX++;
                            break;
                        case "left":
                            playerY--;
                            break;
                        case "right":
                            playerY++;
                            break;
                        default:
                            break;
                    }
                }
                if (playerX < 0)
                {
                    playerX = size + playerX;
                }
                if (playerY < 0)
                {
                    playerY = size + playerY;
                }
                if (playerX>=size)
                {
                    playerX = size-playerX;
                }
                if (playerY>=size)
                {
                    playerY = size-playerY;
                }

                if (matrix[playerX][playerY]=='F')
                {
                    Console.WriteLine("Player won!");
                    isTheGameLost = false;
                    i = int.MaxValue-1;
                }
                matrix[playerX][playerY] = 'f';
            }

            if (isTheGameLost)
            {
                Console.WriteLine("Player lost!");
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
