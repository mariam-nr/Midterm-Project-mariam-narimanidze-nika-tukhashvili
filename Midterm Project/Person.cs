﻿namespace Midterm_Project
{
    public class Person
    {
        public string Name { get; set; }


        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name {Name}";
        }
    }
}
