using System;

namespace S01_Ex10_BiggestDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = {10, 3, 5, 6};
            Console.WriteLine(bigDiff(numbers1));
            
            int[] numbers2 = {7, 2, 10, 9};
            Console.WriteLine(bigDiff(numbers2));
            
            int[] numbers3 = {2, 10, 7, 2};
            Console.WriteLine(bigDiff(numbers3));
        }
        
        /*
         * Write a method with the following behaviour:
         * Given an array length 1 or more of ints, return the difference
         * between the largest and smallest values in the array.
         *
         * bigDiff([10, 3, 5, 6]) → 7
         * bigDiff([7, 2, 10, 9]) → 8
         * bigDiff([2, 10, 7, 2]) → 8
         */
        static int bigDiff(int[] numbers)
        {
            int biggest = numbers[0];
            int lowest = numbers[0];

            foreach (int number in numbers)
            {
                if (number >= biggest)
                    biggest = number;

                if (number <= lowest)
                    lowest = number;
            }

            return biggest - lowest;
        }
    }
}