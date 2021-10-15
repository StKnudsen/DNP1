using System;

namespace S02_Ex05_CarAndPredicates
{
    public class Car
    {
        public string Color { get; set; }
        public double EngineSize { get; set; }
        public double FuelEconomy { get; set; } // in liters pr 100km

        public override string ToString()
        {
            return $"A {Color} car, engine is a {EngineSize} that uses {FuelEconomy} l/100km";
        }
    }
}