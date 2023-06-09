﻿namespace _05_StaticMembers
{
    internal class Person
    {
        private readonly int id;

        public int Id //This property is not passed to the constructor, but the value is set via the private/readonly id field
        {
            get { return id; }
            //private set { id = value; } //set the value internally within the class constructor not while instantiation outside the class
                                          //if this field is private, you cannot set this in the constructor. therefore remove if its readonly
        }

        private const string DEFAULT_COUNTRY = "Never Land"; //YOU CANNOT ASSIGN AN INSTANCE TO A CONST FIELD,
                                                             //BECAUSE INSTANCE CHANGES AND THEREFORE IS NOT CONSTANT,
                                                             //SO USE READONLY IN THAT CASE ...
    
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public static int Count { get; set; }

        

        public Person(string name, string lastName, int age)
        {
            Count++; //this key word doesnt apply here or to the static members. It points to a specific instance of the class.
                     //Static members are shared by all instances of the class.
                     //Id = Count; //if the field is readonly, we cannot set the property but we can only set the private field as show below (lower case)
            id = Count;
            Name = name;
            LastName = lastName;
            Age = age;
        }
        
        public static void PrintCount()
        {
            Console.WriteLine($"Count: {Count}");
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, LastName: {LastName}, Age: {Age}, Country: {DEFAULT_COUNTRY}";
        }
    }
}
