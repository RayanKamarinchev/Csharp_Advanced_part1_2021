using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
            while (input!="END")
            {
                string[] cars = Regex.Split(input, ", ");
                if (cars[0]=="IN")
                {
                    parking.Add(cars[1]);
                }
                else
                {
                    parking.Remove(cars[1]);
                }
                input = Console.ReadLine();
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}
