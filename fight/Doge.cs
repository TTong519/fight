using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class Doge : fighter
    {
        public bool hasRabies;
        public bool isWin;
        public Doge(string name, int health, int defence, int attack, int speed, int agility, bool hasRabies)
            : base(name, health, defence, attack, speed, agility)
        {
            this.hasRabies = hasRabies;
        }
    }
}
