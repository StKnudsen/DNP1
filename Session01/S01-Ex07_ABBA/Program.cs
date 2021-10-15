using System;

namespace S01_Ex07_ABBA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABBA string converter...");
            
            Console.WriteLine("Enter first string: ");
            string a = Console.ReadLine();
            
            Console.WriteLine("Enter second string: ");
            string b = Console.ReadLine();
            
            Console.WriteLine(makeAbba(a, b));
            
            Console.Out.WriteLine(makeAbba("Hi", "Bye"));
            Console.Out.WriteLine(makeAbba("Yo", "Alice"));
            Console.Out.WriteLine(makeAbba("What", "Up"));
        }

        /*
         * Given two strings, a and b, return the result of putting them together
         * in the order abba, e.g. "Hi" and "Bye" returns "HiByeByeHi".
         *
         * Examples:
         * makeAbba("Hi", "Bye") → "HiByeByeHi"
         * makeAbba("Yo", "Alice") → "YoAliceAliceYo"
         * makeAbba("What", "Up") → "WhatUpUpWhat"
         */
        static string makeAbba(string a, string b)
        {
            return $"{a}{b}{b}{a}";
        }
    }
}