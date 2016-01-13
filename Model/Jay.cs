using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jay : Gambler
    {
        public Jay() : base("Jay")
        {
            
        }

        public override void FetchNewNumber(int num)
        {
            if (num.IsEven())
            Score++;
        }
    }
}
