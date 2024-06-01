using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class Doge : Fighter
    {
        public bool hasRabies;
        public bool isWin;
        public Doge(string name, int health, int defence, int attack, int speed, int agility, bool hasRabies)
            : base(name, health, defence, attack, speed, agility)
        {
            Rabies rabies = new Rabies();
            this.hasRabies = hasRabies;
            attacks[1] = new Attack(30 + attack, "Bite", 10, 1, 2, rabies);
            attacks[2] = new Attack(10 + attack, "Kick", 50, 2, 3);
            attacks[3] = new Attack(-10, "Heal", 7, 1, 2);
        }
    }
}
