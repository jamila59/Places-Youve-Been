using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace PlacesBeen.Models
{
    public class Location
    {
        public string CityName { get; set; }
        private static List<Location> _instances = new List<Location> { };

        public Location(string cityName)
        {
            CityName = cityName;
            _instances.Add(this);
        }

        public static List<Location> GetAll()
        {
            return _instances;
        }
    }
}