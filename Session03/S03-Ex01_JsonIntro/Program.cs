using System;
using System.Collections.Generic;
using System.Text.Json;

namespace S03_Ex01_JsonIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Person Tina = new Person()
            {
                FirstName = "Tina",
                LastName = "Hadberg",
                Age = 20,
                Height = 170,
                IsMarried = false,
                Sex = 'F',
                Hobbies = new [] {"Otto", "Strikke"}
            };
            Person Line = new Person()
            {
                FirstName = "Line",
                LastName = "Guld",
                Age = 30,
                Height = 160,
                IsMarried = false,
                Sex = 'F',
                Hobbies = new [] {"Planter"}
            };
            Person Stefan = new Person()
            {
                FirstName = "Stefan",
                LastName = "Knudsen",
                Age = 27,
                Height = 180,
                IsMarried = false,
                Sex = 'M',
                Hobbies = new [] {"Bjørn", "Astrid"}
            };
            
            persons.Add(Tina);
            persons.Add(Line);
            persons.Add(Stefan);

            string personsInAString = JsonSerializer.Serialize(persons);
            Console.WriteLine(personsInAString);

            string jsonFormatted = JsonSerializer.Serialize(persons, new JsonSerializerOptions {WriteIndented = true});
            Console.WriteLine(jsonFormatted);
        }
    }
}