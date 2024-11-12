using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppSnakeAndLadder
{
    internal class Program
    {
        public const int size = 100;
        private static int[] board = new int[101];
        static void DisplayBoard(int player1At,int player2At)
        {
            for (int i = size; i >= 1; i--)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                if (i == player1At)
                {
                    Console.Write("* ");
                }  
                else if (i == player2At)
                {
                    Console.Write("# ");

                }  
                else if (board[i] == -17 || board[i] == -35 || board[i] == -55 || board[i] == -22 || board[i] == -15)
                {
                    Console.Write("S  ");
                }    
                else if (board[i] == 14 || board[i] == 50 || board[i] == 71 || board[i] == 88 || board[i] == 96)
                {
                    Console.Write("L  ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
                  
            }
            Console.WriteLine("\n");
        }


    
        static int Game(int playerAt,int dice)
        {
            int newPlace = playerAt + dice;
            if(newPlace > size)
            {
                return playerAt;
            }
            string message = (board[newPlace] > 0) ? "Wow! It's a ladder." : "Hoo.. It's a snake.";

            Console.WriteLine(message);
            newPlace += board[newPlace];
            return newPlace;
        }

        static void Main(string[] args)
        {
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = i;
            }

            // Snakes
            board[27] = -17;
            board[37] = -35;
            board[97] = -55;
            board[48] = -22;
            board[20] = -15;

            // Ladders
            board[6] = 14;
            board[12] = 50;
            board[49] = 71;
            board[54] = 88;
            board[76] = 96;

            int player1At = 1;
            int player2At = 1;
            Random random = new Random();
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Snake and Ladder Game");
                DisplayBoard(player1At,player2At);
                Console.WriteLine("1. player1(*) ");
                Console.WriteLine("2. player2(#) ");
                
                Console.Write("Choose the option to roll the dice: ");
                string choice = Console.ReadLine().Trim();
                int dice = random.Next(1, 7);
                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"player 1 rolled {dice}");
                        player1At = Game(player1At, dice);
                        Console.WriteLine($"Player 1 is at {player1At} ");
                        if (player1At >= size)
                        {
                            Console.WriteLine("Congratulations!!!!!Player 1 wins the game");
                            return;
                        }
                        break;
                    case "2":
                        Console.WriteLine($"player 2 rolled :{dice}");
                        player2At = Game(player2At, dice);
                        Console.WriteLine($"Player 2 is at :{player2At} ");
                        if (player2At >= size)
                        {
                            Console.WriteLine("Congratulations!!!!!Player 2 wins the game");
                            return;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid player option! try again");
                        break;
                }
               
                Thread.Sleep(2000);
                //Console.Clear() ;
                
            }
            Console.ReadKey();

        }
    }
}
