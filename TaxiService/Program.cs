using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiInConstructorInjection taxiInHorse = new TaxiInConstructorInjection(new Horse());
            TaxiInConstructorInjection taxiInBicycle = new TaxiInConstructorInjection(new Bicycle());
            TaxiInConstructorInjection taxiInCar = new TaxiInConstructorInjection(new Car());

            List<TaxiInConstructorInjection> taxi = new List<TaxiInConstructorInjection>();
            taxi.Add(taxiInHorse);
            taxi.Add(taxiInBicycle);
            taxi.Add(taxiInCar);
            for (int i = 0; i < taxi.Count; i++)
            {
                taxi[i].LetsGo();
            }
            Console.WriteLine("Constructor Injection ============================================");
            
            //==============================================//

            TaxiInPropertyInjection taxiInHorseTwo = new TaxiInPropertyInjection();
            TaxiInPropertyInjection taxiInBicycleTwo = new TaxiInPropertyInjection();
            TaxiInPropertyInjection taxiInCarTwo = new TaxiInPropertyInjection();

            taxiInHorseTwo.Injection = new Horse();
            taxiInBicycleTwo.Injection = new Bicycle();
            taxiInCarTwo.Injection = new Car();

            List<TaxiInPropertyInjection> taxiInPropertyInjections = new List<TaxiInPropertyInjection>();
            taxiInPropertyInjections.Add(taxiInCarTwo);
            taxiInPropertyInjections.Add(taxiInBicycleTwo);
            taxiInPropertyInjections.Add(taxiInHorseTwo);

            for (int i = 0; i < taxiInPropertyInjections.Count; i++)
            {
                taxiInPropertyInjections[i].LetsGo();
            }

            Console.WriteLine("Property Injection ============================================");
            //====================================================//

            TaxiInMethodInjection taxiInHorseThree = new TaxiInMethodInjection();
            TaxiInMethodInjection taxiInBicycleThree = new TaxiInMethodInjection();
            TaxiInMethodInjection taxiInCarThree = new TaxiInMethodInjection();

            taxiInHorseThree.LetsGo(new Horse());
            taxiInBicycleThree.LetsGo(new Bicycle());
            taxiInCarThree.LetsGo(new Car());

            List<TaxiInMethodInjection> taxiInMethodInjections = new List<TaxiInMethodInjection>();
            taxiInMethodInjections.Add(taxiInCarThree);
            taxiInMethodInjections.Add(taxiInBicycleThree);
            taxiInMethodInjections.Add(taxiInHorseThree);

            Console.WriteLine("Method Injection ============================================");
            Console.ReadLine();
        }
    }
}
