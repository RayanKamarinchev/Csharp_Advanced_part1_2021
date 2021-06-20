using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //exercise 1
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "1000";
            car.Year = 2020;
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
            //exercise 2
            car.FuelQuantity = 200;
            car.FuelConsuption = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
            //exercise 3
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsuption = double.Parse(Console.ReadLine());
            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsuption);
            //exercise 4
            var tires = new Tire[]
            {
                new Tire(1,2.5),
                new Tire(1,2.1),
                new Tire(2,0.5),
                new Tire(2,2.3),
            };
            var engine = new Engine(560, 6300);
            var carFromEx4 = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);
        }
    }
}
