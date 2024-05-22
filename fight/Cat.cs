using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    internal class Cat : fighter
    {
        public Cat(string name, int health, int defence, int attack, int speed, int agility)
            : base(name, health, defence, attack, speed, agility)
        {
            
        }

    }
}
