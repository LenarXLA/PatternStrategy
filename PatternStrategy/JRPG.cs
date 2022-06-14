using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class JRPG : IRPG
    {
        public void SelectGame()
        {
            Console.WriteLine("JRPG is selected!");
        }
    }
}
