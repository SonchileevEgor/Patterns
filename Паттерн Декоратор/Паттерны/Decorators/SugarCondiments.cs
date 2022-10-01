using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны.Decorators
{
    class SugarCondiments : CondimentsDecoratorBase
    {
        Beverage.BeverageBase _beverage;

        public SugarCondiments(Beverage.BeverageBase beverage)
        {
            _beverage = beverage;
            Description = _beverage.GetDescription() + " + Sugar";

        }

        public override double GetCost()
        {
            return 0;
        }
    }
}