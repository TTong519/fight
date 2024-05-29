using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class Cat : Fighter
    {
        public bool isinfected;
        public Cat(string name, int health, int defence, int attack, int speed, int agility, bool isinfected)
            : base(name, health, defence, attack, speed, agility)
        {
            this.isinfected = isinfected;
        }

    }
}
