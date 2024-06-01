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
            attacks[0] = new Move(30 + attack, "Bite",rabies);
            attacks[1] = new Move(10 + attack, "Kick");
            attacks[2] = new Move(-10, "Heal", null, true);
        }
    }
}
