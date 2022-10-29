using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    abstract class CarBuilderBase
    {
        protected Car Car;

        protected CarBuilderBase()
        {
            Car = new Car();
        }

        public Car GetCar()
        {
            return Car;
        }

        public abstract void BuildMultimedia();
        public abstract void BuildWheels();
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildLuxury();
        public abstract void BuildSafety();
    }
}