using System;

namespace S01_Ex09_Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Substring twice...");
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            
            Console.WriteLine("Enter n chars: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(nTwice(word, n));
            Console.WriteLine(nTwice("Hello", 2));
            Console.WriteLine(nTwice("Chocolate", 3));
            Console.WriteLine(nTwice("Chocolate", 1));
        }
        
        /*
         * Write a method with the following behaviour:
         * Given a string and an int n, return a string made of the first and last
         * n chars from the string. The string length will be at least n.
         *
         * nTwice("Hello", 2) → "Helo"
         * nTwice("Chocolate", 3) → "Choate"
         * nTwice("Chocolate", 1) → "Ce"
         */
        static string nTwice(string word, int n)
        {
            string output = "";
            if (word.Length < n)
            {
                return $"Not going to happen, {word} is less than {n} chars in length, try again...";
            }
                

            for (int i = 0; i < n; i++)
            {
                output += word[i];
            }

            for (int i = 0; i < n; i++)
            {
                output += word[word.Length - n + i];
            }

            return output;
        }
    }
}