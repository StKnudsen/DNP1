using System;

namespace S01_Ex06_MoreMathWithInput.MathLib
{
    public class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        public static int Add(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }
        
        /*
         * Add to the Calculator class from the previous exercise and method that takes two number inputs from
         * the console and then displays the maximum of the two. Call the method from the main method.
         */
        public static int ReturnBiggest(int x, int y)
        {
            return Math.Max(x, y);
        }
    }
}