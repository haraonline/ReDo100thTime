using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ConstructorChaining
{
    internal class Person
    {        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //Chain constructors
        public Person() : this("No Name", 0, "No Address") { }
        public Person(string name) : this(name, 0, "No Address") { }
        public Person(string name, int age) : this(name, age, "No Address") { }
        public Person(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }


    }
}
