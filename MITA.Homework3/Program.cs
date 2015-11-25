using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace MITA.Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbertron numbertron = new Numbertron();
            Jay jay = new Jay();
            SilentBob silentBob = new SilentBob();

            numbertron.NewNumber += silentBob.FetchNewNumber;
            numbertron.NewNumber += jay.FetchNewNumber;

            int count;

           Console.WriteLine("Введите количество чисел для числотрона");
            link1:
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count < 0 || count == 0)
                    {
                        Console.WriteLine("Число должно быть больше нуля");
                        goto link1;
                    }
                    else
                        numbertron.Generate(count);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод");
                    goto link1;
                }
                
                if (jay.Score > silentBob.Score)
                    Console.WriteLine("Jay win");
                else if (jay.Score < silentBob.Score)
                {
                    Console.WriteLine("Silent Bob win");
                }
                else if (jay.Score == silentBob.Score && jay.Score != 0 && silentBob.Score != 0)
                {
                    Console.WriteLine("DRAW");
                }
                
                Console.ReadKey();
            
        }
    }
}
