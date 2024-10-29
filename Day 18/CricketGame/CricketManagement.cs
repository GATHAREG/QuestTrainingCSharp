using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CricketGame
{
    internal class CricketManagement
    {
        public int Over {  get; set; }
        public int NoOfBatsman { get; set; }

        public int ComputerScore { get; set; }
        public int NoOfBalls { get; set; }
        private Batsman batsman;

        Random rand = new Random();

        public CricketManagement(Batsman batsman)
        {
           
            this.batsman = batsman;
            ComputerScore = 0;
            Over = 0;
            NoOfBalls = 0;

        }
        public void Start()
        {
           

            while (true)
            {

                Console.Write("Enter the run of batsman(1,2,3,4,5):");
                int run =  int.Parse(Console.ReadLine());
                int  computerRun  = rand.Next(1,7);
                Console.WriteLine($"Computer guess is : {computerRun}");
                if (run == 5)
                {
                    Console.WriteLine("Its a no ball no score:");
                }
                else if(run == 1 || run == 2 || run == 3 || run == 4 || run == 5)
                {
                    batsman.Score += run;
                    NoOfBalls++;
                }

                else if(run == computerRun)
                {
                    Console.WriteLine("Wow its a wicket");
                    Console.WriteLine($"The player {batsman.Name} is out with {batsman.Score}");

                    Console.Write("Enter the name of new batsman:");
                    batsman.Name = Console.ReadLine();
                    NoOfBatsman++;

                }

                if(NoOfBatsman == 10)
                {
                    Console.WriteLine($"The Game is over with no wicket left at {Over} ");
                }

                Console.WriteLine($"Current score is :{batsman.Score}");


                if (NoOfBalls == 6)
                {
                    Console.WriteLine("An over reached");
                    Over++;
                    NoOfBalls = 0;
                }
                if(Over == 5)
                {
                    Console.WriteLine($"The score is {batsman.Score} at {Over}");
                    Console.WriteLine("Game over");
                    break;
                }



                

            }
        }
    }
}
