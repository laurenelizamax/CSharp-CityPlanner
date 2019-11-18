using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Building> buildings = new List<Building>();

            Building firstAve = new Building("1st Ave North");
            firstAve.Width = 30;
            firstAve.Depth = 60;
            firstAve.Stories = 20;
            firstAve.Purchase("Dylan");
            firstAve.Construct();

            Building mainSt = new Building("200 Main St.");
            mainSt.Width = 40;
            mainSt.Depth = 70;
            mainSt.Stories = 30;
            mainSt.Purchase("Shirish");
            mainSt.Construct();

            Building plusPark = new Building("301 Plus Park Blvd");
            plusPark.Width = 300;
            plusPark.Depth = 200;
            plusPark.Stories = 10;
            plusPark.Purchase("Heidi");
            plusPark.Construct();

            buildings.Add(firstAve);
            buildings.Add(mainSt);
            buildings.Add(plusPark);

            // Console.WriteLine(firstAve.Print());
            // Console.WriteLine(mainSt.Print());
            // Console.WriteLine(plusPark.Print());

            City city = new City("Nashville", "Lauren", 1930);
            city.Buildings.Add(firstAve);
            city.Buildings.Add(mainSt);
            city.Buildings.Add(plusPark);

            Console.WriteLine($"{city.Name} \n {city.Mayor} \n{city.Year} \n ");

            foreach (Building building in city.Buildings)
            {
                Console.WriteLine(building.Print());

            }

        }
    }
}
