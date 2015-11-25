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

        public void Generate(int count)
        {
            Random rnd = new Random();
            for (int i = 0; i < count; i++)
            {
                int num = rnd.Next();
                if (NewNumber != null)
                    NewNumber(num);
                Console.WriteLine(num);
            }
        }
    }
}
