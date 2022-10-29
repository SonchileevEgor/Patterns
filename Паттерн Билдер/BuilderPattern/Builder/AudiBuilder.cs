using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base() {}

        public override void BuildMultimedia()
        {
            Car.Multimedia = "Audi Multimedia";
        }
        public override void BuildWheels()
        {
            Car.Wheels = "R20";
        }
        public override void BuildFrame()
        {
            Car.Frame = "MQB";
        }
        public override void BuildEngine()
        {
            Car.Engine = "2.0 TFSI";
        }
        public override void BuildLuxury()
        {
            Car.Luxury = "Exclusive";
        }
        public override void BuildSafety()
        {
            Car.Safety = "Side Assist";
        }
    }
}