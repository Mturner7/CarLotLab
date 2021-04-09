using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotApp
{
    class Validator
    {
        public static bool ContinuePrompt(string msg)
        {
            string input;
            do
            {
                Console.Write($"\n{msg} (y/n): ");
                input = Console.ReadLine().ToLower();

                if (input == "y") return true;

            } while (input != "n");

            return false;
        }

        public static Car GenerateCar()
        {
            int year;
            decimal price;
            double mileage;

            Console.Write("Enter the new Car's make: ");
            string make = Console.ReadLine();

            Console.Write("Enter the new Car's model: ");
            string model = Console.ReadLine();

            Console.Write("Enter the new Car's year: ");
            while (!Int32.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("\nThat's not a valid year. Keep it clear and try again. \n");
            }

            Console.Write("Enter the new Car's current price: ");
            while (!Decimal.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("\nThat's not a valid price. Be nice and try again. \n");
            }

            Console.Write("Enter the new Car's total mileage: ");
            while (!Double.TryParse(Console.ReadLine(), out mileage))
            {
                Console.WriteLine("\nThat's not a valid mileage. Try again. \n");
            }

            if (mileage < 200) return new Car(year, make, model, price);

            return new UsedCar(year, make, model, price, mileage);
        }

        public static int ValidateIndex(int max, string msg)
        {
            int index;

            do
            {
                Console.Write($"\n{msg} (enter a number 1-{max}) ");
                Int32.TryParse(Console.ReadLine(), out index);
        
            } while (index < 1 || index > max);
            
            return index;
        }
    }
}
