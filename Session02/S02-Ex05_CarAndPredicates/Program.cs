using System;
using System.Collections.Generic;
using System.Linq;

namespace S02_Ex05_CarAndPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new CarRepository().GetCars();

            List<Car> BlackOrBlue = cars.FindAll(car => car.Color.Equals("Black") || car.Color.Equals("Blue"));
            List<Car> BlackOrBlueArr = cars.FindAll(GetByColors);
            List<Car> EngineBigger = cars.FindAll(car => car.EngineSize > 1.5);
            List<Car> EngineBetween = cars.FindAll(car => car.EngineSize > 1.0 && car.EngineSize < 2.0);
            List<Car> FuelEcon = cars.FindAll(car => car.FuelEconomy < 6.00);
            List<Car> FuelEconAndBlue = cars.FindAll(car => car.FuelEconomy < 6.00 && car.Color.Equals("Blue"));
            

            PrintCarList(BlackOrBlue);
            PrintCarList(BlackOrBlueArr);
            PrintCarList(EngineBigger);
            PrintCarList(EngineBetween);
            PrintCarList(FuelEcon);
            PrintCarList(FuelEconAndBlue);
        }

        static bool GetByColors(Car obj)
        {
            string[] colors = {"Black", "Blue"};
            
            return colors.Contains(obj.Color);
        }

        static void PrintCarList(List<Car> cars)
        {
            Console.WriteLine("Cars in this list:");
            foreach (Car car in cars)
            {
                Console.WriteLine($"   {car}");
            }
        }
    }
}