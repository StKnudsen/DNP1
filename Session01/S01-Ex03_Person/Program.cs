using System;

namespace S01_Ex03_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                // Creating an object with "Object initializer"
                // instead of a constructor in the class! 
                Name = "Jack Black"
            };
            
            Console.WriteLine(person.Introduce());
        }
    }
}