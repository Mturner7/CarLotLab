using System;

namespace CarLotApp
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        
        public Car() { }

        public Car(int year, string make, string model, decimal price)
        {
            Year = year;
            Make = make;
            Model = model;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Year, -5} | {Make, -7} | {Model, -15} | {$"${Price}", 10}|";
        }


    }
}
