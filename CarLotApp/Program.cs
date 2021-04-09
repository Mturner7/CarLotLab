using System;
using System.Collections.Generic;

namespace CarLotApp
{
    class Program
    {
        static List<Car> cars = new List<Car>()
        {
            new Car(2002, "Honda", "Civic", 4999.89m),
            new Car(2021, "Chevy", "V6 Silverado", 2721m),
            new UsedCar(2021, "Icey", "Pooh Shiesty", 56000m, 300),
            new UsedCar(2021, "Ford", "Explorer", 0.99m, 5000000),
            new Car(1991, "Ford", "Pinto", 29991m),
            new Car(2005, "Toyota", "Albatross", 5432m),
            new UsedCar(2019, "Ferrari", "LaFerrari", 80085m, 201),
            new UsedCar(2010, "McLaren", "P300", 272221m, 200),
            new Car(1950, "Jeep", "Trailblazer", 21m),
            new UsedCar(2021, "Tesla", "Model S", 5721m, 2022),
            new Car(2021, "BMW", "Beamer", 2721m)
        };
       
        static void DisplayMenu()
        {
            CarLot.ViewInventory();

            Console.WriteLine("\n [1] Add a car\t [2] Buy a car");

            int index = Validator.ValidateIndex(2, "What would you like to do?");

            switch (index)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You chose 'Add a car' \n");
                    Car car = Validator.GenerateCar();
                    CarLot.AddCar(car);
                    break;

                case 2:
                    index  = Validator.ValidateIndex(CarLot.Inventory.Count, "Which car would you like to purchase?");
                    CarLot.RemoveCar(index - 1);
                    break;
            }
        }


        static void Main(string[] args)
        {
            CarLot.Inventory = cars;
            bool running = true;

            while (running)
            {
                DisplayMenu();
                running = Validator.ContinuePrompt("Would you like to continue?");
            }

            Console.WriteLine("\nThanks for shopping with us\n");
        }
    }
}
