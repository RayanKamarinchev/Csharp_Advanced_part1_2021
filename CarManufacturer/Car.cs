
namespace CarManufacturer
{
    class Car
    {
        private string make;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        private double fuelConsuption;

        public double FuelConsuption
        {
            get { return fuelConsuption; }
            set { fuelConsuption = value; }
        }

        public void Drive(double distance)
        {
            double result = fuelConsuption * distance;
            if (result<fuelQuantity)
            {
                fuelQuantity -= result;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsuption = 10;
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsuption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsuption = fuelConsuption;
        }

        private Engine engine;

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        private Tire[] tires;

        public Tire[] Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsuption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsuption)
        {
            Engine = engine;
            Tires = tires;
        }
    }
}
