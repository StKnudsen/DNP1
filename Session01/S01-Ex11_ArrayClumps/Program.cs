using System;

namespace S01_Ex11_ArrayClumps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 1, 1, 2, 3, 2, 2, 1, 1, 1, 1, 1}; // 3 clumps
            Console.WriteLine(countClumps(numbers));
            
            int[] numbers1 = {1, 2, 2, 3, 4, 4};
            Console.WriteLine(countClumps(numbers1));
            
            int[] numbers2 = {1, 1, 2, 1, 1};
            Console.WriteLine(countClumps(numbers2));
            
            int[] numbers3 = {1, 1, 1, 1, 1};
            Console.WriteLine(countClumps(numbers3));
        }
        
        /*
         * Write a method with the following behaviour:
         * Say that a "clump" in an array is a series of 2 or more adjacent elements
         * of the same value. Return the number of clumps in the given array.
         *
         * countClumps([1, 2, 2, 3, 4, 4]) → 2
         * countClumps([1, 1, 2, 1, 1]) → 2
         * countClumps([1, 1, 1, 1, 1]) → 1
         */
        static int countClumps(int[] array)
        {
            int Clumps = 0;
            int? LastNumber = null;
            bool LastNumberClumpNumber = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    LastNumber = array[i];
                }
                else if (LastNumber == array[i])
                {
                    if (!LastNumberClumpNumber)
                    {
                        Clumps++;
                        LastNumberClumpNumber = true;
                    }
                }
                else
                {
                    LastNumberClumpNumber = false;
                }

                LastNumber = array[i];
            }

            return Clumps;
        }
    }
}