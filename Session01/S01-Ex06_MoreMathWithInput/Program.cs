using System;

namespace S01_Ex06_MoreMathWithInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter first integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Biggest number is: {MathLib.Calculator.ReturnBiggest(x, y)}");
        }
    }
}