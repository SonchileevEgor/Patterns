using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Паттерны.Beverage
{
    public class Tea: BeverageBase
    {
        public Tea()
        {
            Description = "Black tea";
        }
        public override double GetCost()
        {
            return 25;
        }
    }
}