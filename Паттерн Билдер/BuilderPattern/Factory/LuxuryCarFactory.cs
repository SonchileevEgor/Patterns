using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;

namespace BuilderPattern.Factory
{
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase builder) : base(builder) {}

        public override Car Construct()
        {
            CarBuilder.BuildFrame();
            CarBuilder.BuildEngine();
            CarBuilder.BuildWheels();
            CarBuilder.BuildSafety();
            CarBuilder.BuildLuxury();
            CarBuilder.BuildMultimedia();

            return CarBuilder.GetCar();
        }
    }
}