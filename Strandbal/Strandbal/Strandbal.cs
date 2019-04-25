using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strandbal
{
    class Strandbal
    {
        public double bal = 25.0;

        public bool Verderopblazen(double extra)
        {
            if(bal<= 150.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
