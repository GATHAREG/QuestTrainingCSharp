using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Random rand = new Random();
            Console.Write("Enter the name of user:");
            string name = Console.ReadLine();
            var user = new User(name);
            var game = new GameManagement(user);
            game.Run();

            
        }
    }
}
