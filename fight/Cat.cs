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
        public bool isWaterBodyActive;
        public Cat(string name, int health, int defence, int attack, int speed, int agility)
            : base(name, health, defence, attack, speed, agility)
        {
            attacks[0] = new Move(25 + attack, "Scratch");
            attacks[1] = new Move(20 + attack, "Bite");
            attacks[2] = new Move(0, "Water Body", null, true);
        }
    }
}
