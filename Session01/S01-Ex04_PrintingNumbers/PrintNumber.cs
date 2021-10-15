using System;

namespace S01_Ex04_PrintingNumbers
{
    public class PrintNumber
    {
        /*
         * Write a method, which prints out all even numbers between 0 and x, where x is
         * a method parameter. Call it from the Main method and verify the output.
         */
        public static void PrintEvenNumbers(int x)
        {
            string values = $"List of even numbers between \"0\" and \"{x}\": ";
            
            for (int i = 1; i < x; i++) // Will be the numbers between 0 and x
            {
                if (i % 2 == 0)
                {
                    values += i + " ";
                }
            }

            Console.WriteLine(values);
        }
        
        /*
         * Write a method, which prints out all uneven numbers between 0 and x, where x is
         * a method parameter. Call it from the Main method and verify the output.
         */
        public static void PrintOddNumbers(int x)
        {
            string values = $"List of odd numbers between \"0\" and \"{x}\": ";
            
            for (int i = 1; i < x; i++)
            {
                if (i%2 != 0)
                {
                    values += $"{i} ";
                }
            }

            Console.WriteLine(values);
        }
        
        /*
         * Write a method, which prints out all numbers divisible by y, between 0 and x, where x
         * and y are method parameters. Call it from the Main method and verify the output.
         */
        public static void NumbersDivisible(int x, int y)
        {
            string values = $"List of numbers divisible by {y} between \"0\" and \"{x}\": ";
            
            for (int i = 1; i < x; i++)
            {
                if (i%y == 0)
                {
                    values += $"{i} ";
                }
            }

            Console.WriteLine(values);
        }
    }
}