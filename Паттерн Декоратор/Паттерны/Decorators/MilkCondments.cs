using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны.Decorators
{
    class MilkCondiments: CondimentsDecoratorBase
    {
        Beverage.BeverageBase _beverage;

        public MilkCondiments (Beverage.BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " + Milk";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 30;
        }
    }
}