using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.Builder;
using BuilderPattern.Factory;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // VW
            Console.WriteLine("Cheap Volkswagen");
            CarFactoryBase constructor = new CheapCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Lux Volkswagen");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            // AUDI

            Console.WriteLine("Cheap AUDI");
            constructor = new CheapCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Lux Audi");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);
        }
    }
}