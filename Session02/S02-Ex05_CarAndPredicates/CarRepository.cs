using System.Collections.Generic;

namespace S02_Ex05_CarAndPredicates
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            return new()
            {
                new Car() { Color = "Red", EngineSize = 1.0, FuelEconomy = 6.66 },
                new Car() { Color = "Blue", EngineSize = 1.4, FuelEconomy = 5.66 },
                new Car() { Color = "Red", EngineSize = 2.0, FuelEconomy = 7.66 },
                new Car() { Color = "Green", EngineSize = 1.6, FuelEconomy = 5.66 },
                new Car() { Color = "Black", EngineSize = 2.2, FuelEconomy = 6.66 },
                new Car() { Color = "Red", EngineSize = 1.4, FuelEconomy = 7.66 }
            };
        }
    }
}