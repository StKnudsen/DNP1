namespace S01_Ex05_MathWithNamespace.MathLib
{
    /*
     * Create a Calculator class and put it in it's own MathLib namespace.
     * Optionally, create a separate folder for this class.
     */
    public class Calculator
    {
        /*
         * Create an Add method in the calculator that takes two numbers and
         * returns their sum. Use it in the Main method of Program.cs.
         */
        public static int Add(int x, int y)
        {
            return x + y;
        }
        
        /*
         * Add an overload method for Add that takes an array of integers, adds
         * them together, then returns the result. Use the for-each loop.
         */
        public static int Add(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                result += number;
            }

            return result;
        }
    }
}