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
        public int stat;
        public int eff;
        public SP(int stat, bool isRec = false,int eff = 0) 
        {
            isRecurring = isRec;
            this.stat = stat;
            this.eff = eff;
        }
    }
}
