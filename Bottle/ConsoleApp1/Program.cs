using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        delegate void Fill(int value);
        delegate void Pour(int value);
        static Bottle bottle = new Bottle();
        static void Main(string[] args)
        {
            Fill FillBottle = bottle.AddVolume;
            Pour PourBottle = bottle.MinusVolume;
            string answer;

            do
            {
                Console.WriteLine("Что вы хотите сделать с бутылкой? \n1. Наполнить \n2. Вылить \nДля выхода из программы введите exit");
                answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("На сколько вы хотите наполнить бутылку?");
                    FillBottle(int.Parse(Console.ReadLine()));
                }
                else if (answer == "2")
                {
                    Console.WriteLine("На сколько вы хотите вылить бутылку?");
                    PourBottle(int.Parse(Console.ReadLine()));
                }

            } while (answer != "exit");
        }
    }
}
