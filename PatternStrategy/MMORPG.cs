using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class MMORPG : IRPG
    {
        public void SelectGame()
        {
            Console.WriteLine("MMORPG is selected!");
        }
    }
}
