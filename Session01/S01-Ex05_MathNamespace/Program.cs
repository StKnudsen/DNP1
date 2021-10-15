using System;

namespace S01_Ex05_MathWithNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLib.Calculator.Add(20, 22));
            
            int[] numbers = {12, 14, 16};
            Console.WriteLine(MathLib.Calculator.Add(numbers));
        }
    }
}