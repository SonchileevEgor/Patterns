using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder() : base() {}

        public override void BuildMultimedia()
        {
            Car.Multimedia = "VW Multimedia";
        }
        public override void BuildWheels()
        {
            Car.Wheels = "R15";
        }
        public override void BuildFrame()
        {
            Car.Frame = "MLB";
        }
        public override void BuildEngine()
        {
            Car.Engine = "1.4 BCA";
        }
        public override void BuildLuxury()
        {
            Car.Luxury = "SPECIAL";
        }
        public override void BuildSafety()
        {
            Car.Safety = "ESP, ABS, DL Audio";
        }
    }
}