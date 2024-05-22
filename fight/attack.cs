using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class attack
    {
        public string name;
        public int damage;
        int energymax;
        int energy;
        int energyuse;
        public attack(int damage, string name, int energymax, int energyuse)
        {
            this.damage = damage;
            this.name = name;
            this.energymax = energymax;
            this.energyuse = energyuse;
        }
    }
}
