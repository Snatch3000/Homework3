using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SilentBob : Gambler
    {
        public SilentBob() : base("Silent Bob")
        {
            
        }

        public override void FetchNewNumber(int num)
        {
            if(Extension.IsEven(num)==false)
            Score++;
        }
    }
}
