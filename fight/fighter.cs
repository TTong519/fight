using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public abstract class Fighter
    {
        public string name;
        public int health;
        public int defence;
        public int attack;
        public int speed;
        public int agility;
        public Move[] attacks;
        public Fighter(string name, int health, int defence, int attack, int speed, int agility)
        {
            this.name = name;
            this.health = health + 100;
            this.defence = defence;
            this.attack = attack;
            this.speed = speed;
            this.agility = agility;
            attacks = new Move[3];
        }
    }
}
