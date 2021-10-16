using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace S03_Ex02_JsonFileStorage
{
    class Program
    {
        private static IList<Person> personList;
        
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
            WriteFile(personsInAString);

            string personsFromFile = ReadFile();
            Console.WriteLine(personsFromFile);

            personList = JsonSerializer.Deserialize<List<Person>>(personsFromFile);

            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }
        }

        private static void WriteFile(string content)
        {
            File.WriteAllText("persons.txt", content);
        }

        private static string ReadFile()
        {
            return File.ReadAllText("persons.txt");
        }
    }
}