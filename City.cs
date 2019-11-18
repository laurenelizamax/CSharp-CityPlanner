using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        public List<Building> Buildings { get; set; }
        public string Name { get; }
        public string Mayor { get; }
        public int Year { get; }
        public City(string name, string mayor, int year)
        {
            Name = name;
            Mayor = mayor;
            Year = year;

            Buildings = new List<Building>();
        }
    }
}