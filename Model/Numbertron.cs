using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void MethodNumbertron(int arr);

        public event MethodNumbertron NewNumber;

        Random rnd = new Random();

        public void Generate()
        {
              
                int num = rnd.Next();
                if (NewNumber != null)
                    NewNumber(num);                        
        }
    }
}
