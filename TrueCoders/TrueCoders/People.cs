using System;
using System.Collections.Generic;
using System.Text;

namespace TrueCoders
{
    class People
    {
        public int Age { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Haircolor { get; set; }

        public People(string firstName, string lastName, int age, string hairColor)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Haircolor = hairColor;

            Console.WriteLine($"Name: {firstName} {lastName}, Age: {age}, Hair Color: {hairColor}");
            Console.WriteLine();
        }
    }
}
