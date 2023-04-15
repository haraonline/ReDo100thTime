using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StaticClassesAndSingletons
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Phone { get; set; }

        public Person(string firstName, string secondName, int phone)
        {
            FirstName = firstName;
            LastName = secondName;
            Phone = phone;
        }

        public string ReturnInstanceAsText()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Phone: {Phone}";

        }
    }
}
