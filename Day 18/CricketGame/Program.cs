using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the player name");
            string name = Console.ReadLine();
            var batsman = new Batsman(name);
            var cricket = new CricketManagement(batsman);
            cricket.Start();
        }
    }
}
