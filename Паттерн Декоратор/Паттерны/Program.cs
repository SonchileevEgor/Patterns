using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Паттерны.Beverage;
using Паттерны.Decorators;

namespace Паттерны 
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Espresso();
            Print(espresso);
            
            Console.WriteLine("______________");

            BeverageBase capucino = new MilkCondiments(new Espresso());
            Print (capucino);
        }

        static void Print(BeverageBase beverage)
        {
            Console.WriteLine("Напиток: {0}; Стоимость: {1}", beverage.GetDescription(), beverage.GetCost());
        }
    }
}