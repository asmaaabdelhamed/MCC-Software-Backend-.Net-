using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Library_management_system
{
    internal class Person
    {
        private int age;
        public string name { set; get; }
        public int Age
        { 
            get { return age; }
            set { age = value; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void DisplayRole()
        {
            Console.WriteLine($"person {name} (age {age})");
        }

            public class Student : Person
    {
        public Student(string name, int age): base(name, age)
        { }
        public override void DisplayRole()
        {
            Console.WriteLine($"student {name}(age {age})");
        }
    }

    public class Librarian: Person
    {
        public Librarian(string name, int age) : base(name, age)
        { }
        public override void DisplayRole()
        {
            Console.WriteLine($"librarian {name}(age {age})");
        }
    }

    }
}
