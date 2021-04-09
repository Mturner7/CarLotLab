using System;
using System.Collections.Generic;

namespace CarLotApp
{
    class CarLot
    {
        public static List<Car> Inventory { get; set; } = new List<Car>();

        public static void ViewInventory()
        {
            string separator = new string('=', 80);
            Console.Clear();
            Console.WriteLine($"There are {Inventory.Count} cars in our inventory.\n\n{separator}");

            for (int i = 0; i < Inventory.Count; i++)
            {
                Console.WriteLine($"{$"[{i + 1}]", -4}  {Inventory[i]}");
            }
            Console.WriteLine(separator + "\n");
        }

        public static void AddCar(Car car)
        {
            if (Inventory.Contains(car)) Console.WriteLine("\nThe automobile you're trying to add is already accounted for");
            else
            {
                Inventory.Add(car);
                Console.WriteLine($"\n'{car.Year} " +
                $"{car.Make} {car.Model}' priced at ${car.Price} has been added to our inventory\n");
            }
        }

        public static void RemoveCar(int index)
        {
            Console.WriteLine($"\nYou purchased '{Inventory[index].Year} " +
           $"{Inventory[index].Make} {Inventory[index].Model}' for ${Inventory[index].Price}!\n");
            Inventory.RemoveAt(index);
        }
    }
}
