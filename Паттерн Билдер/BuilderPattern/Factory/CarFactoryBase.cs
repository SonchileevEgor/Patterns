using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;

namespace BuilderPattern.Factory
{
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase CarBuilder;

        protected CarFactoryBase(CarBuilderBase builder)
        {
            CarBuilder = builder;
        }

        public abstract Car Construct();
    }
}