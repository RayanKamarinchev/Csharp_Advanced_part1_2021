using System;

namespace _06.SpeedRace
{
    class Car
    {
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double fuelAmount;

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        private double fuelConsumptionPerKilometer;

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        private double travelledDistance;

        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public void Drive(double km)
        {
            double traveled = fuelConsumptionPerKilometer * km;
            if (fuelAmount<traveled)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                fuelAmount -= traveled;
                travelledDistance += km;
            }
        }
    }
}
