using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            // EliotTowers is type 'Building'
            // 'new' makes a new instance of 'Building'

            Building EliotTowers = new Building("420 Avenue"){
                Width = 60,
                Depth = 90,
                Stories = 3
            };

            // WillisTower is type 'Building'
            // 'new' makes a new instance of 'Building'

            Building WillisTower = new Building("500 Avenue"){
                Width = 50,
                Depth = 40,
                Stories = 100
            };

            // Chicago is type 'City'
            // 'new' makes a new instance of 'City'

            City Chicago = new City();

            // Chicago is type 'City'
            // AddBuilding is a method only acctepting parameters of type 'Building'
            // The 'City' Chicago has a 'Building' which is 'WillisTower

            Chicago.AddBuilding(WillisTower);

            EliotTowers.Construct();

            EliotTowers.Purchase("Shelley");

            Console.WriteLine
            (EliotTowers.Address);
            Console.WriteLine("---");
            Console.WriteLine($"Designed by {EliotTowers.Designer}");
            Console.WriteLine($"---");
            Console.WriteLine($"Owned by {EliotTowers.Owner}");
            Console.WriteLine($"---");
            Console.WriteLine($"Constructed on {EliotTowers.DateConstructed}");
            Console.WriteLine($"---");
            Console.WriteLine($"Address for building is {EliotTowers.Address}");
        }
    }
}
