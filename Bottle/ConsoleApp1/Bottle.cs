using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bottle
    {
        const int maxVolume = 200;
        static int volume = 200;
        public int Volume { get; }

        public Bottle()
        {

        }

        public void AddVolume(int value)
        {
            if(volume/maxVolume*100 >= 95)
            {
                Console.WriteLine("Бочка заполнена на {0}% ({1} литров). Вы уверены что хотите продолжить? Да/Нет", volume/maxVolume*100, volume);
                if (Console.ReadLine().ToLower() == "да")
                    volume += value;
                else
                    return;
            }
            else
            {
                volume += value;
            }

            Console.WriteLine("В бочке после наполнения {0} литров", volume);
        }

        public void MinusVolume(int value)
        {
            if(volume - value < 0)
            {
                Console.WriteLine("При вычитании {0} литров воды, значение в бочке будет отрицательным. Вы уверены что хотите продолжить? Да/Нет", value);
                if (Console.ReadLine().ToLower() == "да")
                    volume -= value;
                else
                    return;
            }
            else
                volume -= value;

            Console.WriteLine("В бочке после вычитания {0} литров", volume);
        }
    }
}
