using System;
using System.Collections.Generic;

namespace TrueCoders
{
    class Program
    {
        static void Main(string[] args)
        {

            People person1 = new People("Michael", "Doyle", 32, "Brown");
            People person2 = new People("Troy", "Maxwell", 30, "Blonde");
            People person3 = new People("Rod", "Geddie", 30, "Brown");

            List<People> trueCoders = new List<People>();
            trueCoders.Add(person1);
            trueCoders.Add(person2);
            trueCoders.Add(person3);
        }
    }
}
