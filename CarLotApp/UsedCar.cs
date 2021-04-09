using System;

namespace CarLotApp
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(int year, string make, string model, decimal price, double mileage) 
        : base(year, make, model, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Mileage} miles (Used)";
        }

    }
}
