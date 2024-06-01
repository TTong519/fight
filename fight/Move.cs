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
        bool isOnSelf;
        public Move(int damage, string name, SP effect = null, bool isOnSelf = false)
        {
            this.damage = damage;
            this.name = name;
            this.isOnSelf = isOnSelf;
        }
    }
}
