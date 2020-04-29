using System;

namespace Classes
{
    public class Person
    {
        // Example of a Field
        public string Name;

        // Example of a Method
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // Example of a static method
        // This is how we create a person object from a string.
        // It takes a string and returns a person object.
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Cameron");
            person.Introduce("Computer");
        }
    }
}
