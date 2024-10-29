using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RockPaperScissor
{
    internal class GameManagement

    {
        Random rand = new Random();
        private User user;
        public int ComputerScore { get; set; }

        public GameManagement(User user)
        {
            this.user = user;
            ComputerScore = 0;
        }
        public void Run()
        {
            while (true)
            {
                Console.Write("Enter the choice(1.Rock, 2.Paper, 3.Scissors):");
                int choice = int.Parse(Console.ReadLine());
                int computer = rand.Next(1, 4);
                Console.WriteLine($"Computer showed: {computer}");

                if (choice == 1 && computer == 2 || choice == 1 && computer == 3 || choice == 3 && computer == 2)
                {
                   user.UserScore++;
                    Console.WriteLine("You got it");
                }
                else if (computer == 1 && choice == 2 || computer == 1 && choice == 3 || computer == 3 && choice == 2)
                {
                    ComputerScore++;
                    Console.WriteLine("Computer got this round");
                }
                else if (computer == choice)
                {
                    Console.WriteLine("Both choices are same");
                }
                Console.WriteLine($"Current score  {user.Name}: {user.UserScore}, Computer :{ComputerScore}");


                if (user.UserScore == 10)
                {
                    Console.WriteLine($"User {user.Name} Wins. Congratulations");
                    break;
                }
                else if (ComputerScore == 10)
                {
                    Console.WriteLine($"Computer wins.Good luck");
                    break;
                }
            }

        }





    }
}
