using System;

namespace S01_Ex08_SurroundWith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Surround word with 4 chars...");
            
            Console.WriteLine("Enter chars to surround with (4): ");
            string outer = Console.ReadLine();
            
            Console.WriteLine("Enter the word to be surrounded: ");
            string word = Console.ReadLine();
            
            Console.WriteLine(MakeOutWord(outer, word));
        }
        
        static string MakeOutWord(string outer, string word)
        {
            if (outer.Length != 4)
            {
                return $"The outer to surround the word is {outer.Length} chars and not 4, please try again...";
            }
            
            return $"{outer[0]}{outer[1]}{word}{outer[2]}{outer[3]}";
        }
    }
}