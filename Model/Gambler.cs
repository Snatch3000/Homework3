using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public abstract class Gambler
    {
        private readonly string _name;

        public Gambler(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Score { get; protected set; }

        public abstract void FetchNewNumber(int num);
    }
}
