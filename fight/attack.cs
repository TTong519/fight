using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class Attack
    {
        public string name;
        public int damage;
        int energymax;
        int energyRegen;
        int energyuse;
        public Attack(int damage, string name, int energymax, int energyuse, int ENR, SP effect = null)
        {
            this.damage = damage;
            this.name = name;
            this.energymax = energymax;
            this.energyuse = energyuse;
            energyRegen = ENR;
        }
    }
}
