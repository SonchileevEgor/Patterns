using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;

namespace BuilderPattern.Factory
{
    class CheapCarFactory : CarFactoryBase
    {
        public CheapCarFactory(CarBuilderBase builder) : base(builder) {}

        public override Car Construct()
        {
            CarBuilder.BuildFrame();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();

            return CarBuilder.GetCar();
        }
    }
}