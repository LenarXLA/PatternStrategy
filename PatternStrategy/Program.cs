using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.SelectGame(new MMORPG());
            gamer.SelectGame(new JRPG());
            Console.ReadLine();
        }
    }
}
