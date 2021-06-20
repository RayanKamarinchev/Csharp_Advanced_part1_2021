using System;
using System.Collections.Generic;

namespace _08.CarSaleman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                engines.Add(CreateEngine(input));
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split();
                garage.Add(CreateCar(input, engines));
            }

            foreach (var car in garage)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static Car CreateCar(string[] input, List<Engine> engines)
        {
            string carModel = input[0];
            string engineModel = input[1];
            Engine engine = engines.Find(e => e.Model == engineModel);
            Car car = new Car(carModel,engine);
            if (input.Length>2)
            {
                bool isDigit = int.TryParse(input[2], out int weight);
                if (isDigit)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = input[2];
                }
                if (input.Length > 3)
                {
                    car.Color = input[3];
                }
            }            
            return car;
        }

        public static Engine CreateEngine(string[] input)
        {
            Engine engine = new Engine(input[0],int.Parse(input[1]));
            if (input.Length>2)
            {
                bool isDigit = int.TryParse(input[2], out int displacement);
                if (isDigit)
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = input[2];
                }
                if (input.Length>3)
                {
                    engine.Efficiency = input[3];
                }
            }
            return engine;
        }
    }
}
