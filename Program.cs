using System;
using System.Collections.Generic;
using System.Text.Json;
using JsonIntro;

class Program
{
    static void Main(string[] args)
    {
        var Ionut = new Person
        {
            FirstName = "Ionut",
            LastName = "Rotaru",
            Age = 21,
            Height = 190,
            IsMarried = false,
            Sex = 'M',
            Hobbies = new string[] { "Football, Basketball, Programming" }
        };

        var Alex = new Person
        {
            FirstName = "Alex",
            LastName = "Ionescu",
            Age = 21,
            Height = 183,
            IsMarried = false,
            Sex = 'M',
            Hobbies = new string[] { "Voleyball, Basketball" }
            
        };
        var Bogdan = new Person
        {
            FirstName = "Bogdan",
            LastName = "Drug",
            Age = 22,
            Height = 192,
            IsMarried = false,
            Sex = 'M',
            Hobbies = new string[] { "Gaming, football" }
            
        };
        var people = new List<Person> { Ionut, Alex, Bogdan };

        string peopleAsJson = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine(peopleAsJson);
    }
}

