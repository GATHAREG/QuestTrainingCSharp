using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    internal class Batsman
    {
        public int Score { get; set; }
       
        public string Name { get; set; }

        public Batsman(string name)
        {
            Score = 0;
            Name = name;

        }


    }
}
