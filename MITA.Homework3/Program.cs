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
            while (true)
            {
                Console.WriteLine("Введите количество чисел для числотрона");
                Numbertron numbertron = new Numbertron();
                Jay jay = new Jay();
                SilentBob silentBob = new SilentBob();

                numbertron.NewNumber += silentBob.FetchNewNumber;
                numbertron.NewNumber += jay.FetchNewNumber;

                

                try
                {            
                    int count = Convert.ToInt32(Console.ReadLine());
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbertron.Generate();
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

                    }
                    else
                        Console.WriteLine("Число должно быть больше нуля");
                }

                catch (FormatException)
                {
                    Console.WriteLine("Некорректный ввод");

                }
                Console.WriteLine("Нажмите любую клавишу чтобы попробовать еще раз....");
                Console.ReadKey();
            } 
        }
    }
}
