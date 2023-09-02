using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool win = false;
            string X = "";
            string O = "";
            int a = 0;

            string[,] Array2d = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

            for (int i = 0; i < Array2d.GetLength(0); i++)
            {
                for (int j = 0; j < Array2d.GetLength(1); j++)
                {
                    Console.Write(Array2d[i, j] + " | ");
                }

                Console.WriteLine("\n-----------");
            }

            while (win != true)
            {
                do
                {
                    Console.WriteLine("Player 1: Insert the number where you want to put a X");
                    X = Console.ReadLine();
                    if (X != "X" && X != "x" && X != "O" && X != "o")
                    {
                        for (int i = 0; i < Array2d.GetLength(0); i++)
                        {
                            for (int j = 0; j < Array2d.GetLength(1); j++)
                            {
                                if (X == Array2d[i, j])
                                {
                                    Array2d[i, j] = "X";
                                    a = 1;
                                }
                            }
                        }

                        if (a == 0)
                        {
                            Console.WriteLine($"{X} is not in the game");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{X} is not in the game");
                    }

                } while (a != 1);

                a = 0;

                for (int i = 0; i < Array2d.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2d.GetLength(1); j++)
                    {
                        Console.Write(Array2d[i, j] + " | ");
                    }

                    Console.WriteLine("\n-----------");
                }

                if (Array2d[0, 0] == "X" && Array2d[0, 1] == "X" && Array2d[0, 2] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[1, 0] == "X" && Array2d[1, 1] == "X" && Array2d[1, 2] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[2, 0] == "X" && Array2d[2, 1] == "X" && Array2d[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[0, 0] == "X" && Array2d[1, 0] == "X" && Array2d[2, 0] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[0, 1] == "X" && Array2d[1, 1] == "X" && Array2d[2, 1] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[0, 2] == "X" && Array2d[1, 2] == "X" && Array2d[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[0, 0] == "X" && Array2d[1, 1] == "X" && Array2d[2, 2] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }
                else if (Array2d[0, 2] == "X" && Array2d[1, 1] == "X" && Array2d[2, 0] == "X")
                {
                    Console.WriteLine("Congratulations Player1! You Win!");
                    Console.ReadLine();
                    break;
                }

                int e = 0;

                foreach (string i in Array2d)
                {
                    if (i == "O" || i == "X")
                    {
                        e++;
                    }
                }

                if (e == 9)
                {
                    Console.WriteLine("None of the players win");
                    Console.ReadLine();
                    break;
                }

                do
                {
                    Console.WriteLine("Player 2: Insert the number where you want to put a O");
                    O = Console.ReadLine();
                    if (O != "O" && O != "o" && O != "X" && X != "x")
                    {
                        for (int i = 0; i < Array2d.GetLength(0); i++)
                        {
                            for (int j = 0; j < Array2d.GetLength(1); j++)
                            {
                                if (O == Array2d[i, j])
                                {
                                    Array2d[i, j] = "O";
                                    a = 1;
                                }
                            }
                        }

                        if (a == 0)
                        {
                            Console.WriteLine($"{O} is not in the game");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{O} is not in the game");
                    }

                } while (a != 1);

                a = 0;

                for (int i = 0; i < Array2d.GetLength(0); i++)
                {
                    for (int j = 0; j < Array2d.GetLength(1); j++)
                    {
                        Console.Write(Array2d[i, j] + " | ");
                    }

                    Console.WriteLine("\n-----------");
                }

                if (Array2d[0, 0] == "O" && Array2d[0, 1] == "O" && Array2d[0, 2] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[1, 0] == "O" && Array2d[1, 1] == "O" && Array2d[1, 2] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[2, 0] == "O" && Array2d[2, 1] == "O" && Array2d[2, 2] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[0, 0] == "O" && Array2d[1, 0] == "O" && Array2d[2, 0] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[0, 1] == "O" && Array2d[1, 1] == "O" && Array2d[2, 1] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[0, 2] == "O" && Array2d[1, 2] == "O" && Array2d[2, 2] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[0, 0] == "O" && Array2d[1, 1] == "O" && Array2d[2, 2] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }
                else if (Array2d[0, 2] == "O" && Array2d[1, 1] == "O" && Array2d[2, 0] == "O")
                {
                    win = true;
                    Console.WriteLine("Congratulations Player2! You Win!");
                    Console.ReadLine();
                }

                e = 0;

                foreach (string i in Array2d)
                {
                    if (i == "O" || i == "X")
                    {
                        e++;
                    }
                }

                if (e == 9)
                {
                    Console.WriteLine("None of the player wins");
                    Console.ReadLine();
                    break;
                }
            }

            Console.WriteLine("End of the Game");
            Console.ReadLine();

        }
    }
}
