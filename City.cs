using System;
using System.Collections.Generic;

namespace Planner
{

    public class City // Public class City is created
    {

        private string _cityName { get; set; } // This is a field. You know this because it is set to private

        public string mayorName { get; set; } // This is a property.

        private string _yearEstablished { get; set; } // This is a field. You know this because it is set to private

        // 'cityBuildings' is a List
        // 'cityBuildings' is of type 'Building'

        public List<Building> cityBuildings { get; set; } = new List<Building>();

        // AddBuilding is a method that can only pass a 'Building' type
        public void AddBuilding(Building cityBuilding)
        {

            //cityBuidlings is a property
            //cityBuilding is a parameter or an argument

            cityBuildings.Add(cityBuilding);

      }
    }
}

// Building is a custom class that is an object that stores different types of data as properties.

