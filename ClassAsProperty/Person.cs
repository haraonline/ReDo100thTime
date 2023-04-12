using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ClassAsProperty
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Address HomeAddress { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate, Address homeAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HomeAddress = homeAddress;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} was born on {BirthDate.ToShortDateString(),10} and lives at {HomeAddress}";
        }
    }    
}
