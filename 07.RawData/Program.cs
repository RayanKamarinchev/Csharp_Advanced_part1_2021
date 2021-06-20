using System;
using System.Linq;

namespace _07.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] garage = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = { new Tire(double.Parse(input[5]), int.Parse(input[6]))
                        , new Tire(double.Parse(input[7]), int.Parse(input[8]))
                        ,new Tire(double.Parse(input[9]),int.Parse(input[10]))
                        ,new Tire(double.Parse(input[11]),int.Parse(input[12]))
                };
                garage[i] = new Car(input[0]
                    , new Engine(int.Parse(input[1]), int.Parse(input[2]))
                    , new Cargo(int.Parse(input[3]), input[4])
                    , tires);
            }

            string command = Console.ReadLine();
            if (command == "fragile") 
            {
                foreach (var car in garage)
                {
                    if (car.Cargo.Type == command) 
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (car.Tires[i].Pressure < 1)
                            {
                                Console.WriteLine(car.Model);
                                break;
                            }                        
                        }
                    }                    
                }
            }
            else
            {
                foreach (var car in garage)
                {
                    if (car.Cargo.Type == command&&car.Engine.Power>250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
