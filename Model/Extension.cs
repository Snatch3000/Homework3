using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class Extension
    {
        public static bool IsEven(this int numer)
        {
            if (numer%2 == 0)
             return true;
            return false;
        }
    }
}
