using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны.Beverage
{
    public class Espresso: BeverageBase
    {
        public Espresso()
        {
            Description = "Strong coffee";
        }
        public override double GetCost()
        {
            return 150;
        }
    }
}