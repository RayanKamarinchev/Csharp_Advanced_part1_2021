using System;
using System.Collections.Generic;

namespace _06.SpeedRace
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> garage = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                garage[input[0]] = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
            }

            string[] command = Console.ReadLine().Split();
            while (command[0]!="End")
            {
                garage[command[1]].Drive(double.Parse(command[2]));
                command = Console.ReadLine().Split();
            }
            foreach (var car in garage)
            {
                Console.WriteLine($"{car.Value.Model} {car.Value.FuelAmount:F2} {car.Value.TravelledDistance}");
            }
        }
    }
}
