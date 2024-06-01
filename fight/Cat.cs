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
            attacks[1] = new Attack(25 + attack, "Scratch", 20, 1, 2);
            attacks[2] = new Attack(20 + attack, "Bite", 50, 2, 3);
            attacks[3] = new Attack(0, "Water Body", 9, 1, 0);
        }

    }
}
