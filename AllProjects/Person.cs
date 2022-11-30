using System;
namespace AllProjects
{
    public abstract class Person
    {
        public string Name { get; }

        public Person(string name)
        {
            Name = name;
        }
    }
}

