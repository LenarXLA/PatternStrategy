using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class Gamer
    {
        public void SelectGame(IRPG rpg)
        {
            if (rpg != null)
                rpg.SelectGame();
        }
    }
}
