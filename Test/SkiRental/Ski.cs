using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    class Ski
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Ski(string manu, string model, int year)
        {
            Manufacturer = manu;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Manufacturer} - {Model} - {Year}";
        }
    }
}
