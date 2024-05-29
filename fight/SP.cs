using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight
{
    public class SP
    {
        public bool isRecurring;
        public int DMG;
        public int stat;
        public int eff;
        public SP(int stat, bool isRec = false, int dmg = 0, int eff = 0) 
        {
            isRecurring = isRec;
            DMG = dmg;
            this.stat = stat;
            this.eff = eff;
        }
    }
}
