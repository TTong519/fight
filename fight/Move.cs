using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class Move
    {
        public string name;
        public int damage;
        int energymax;
        int energyRegen;
        int energyuse;
        bool isOnSelf;
        public Move(int damage, string name, int energymax, int energyuse, int ENR, SP effect = null, bool isOnSelf = false)
        {
            this.damage = damage;
            this.name = name;
            this.energymax = energymax;
            this.energyuse = energyuse;
            this.isOnSelf = isOnSelf;
            energyRegen = ENR;
        }
    }
}
