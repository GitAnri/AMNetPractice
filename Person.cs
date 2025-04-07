using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class Person
    {
        private int age;
        public string Name { get; set; }

        public Person(int age, string name)
        {   
            this.age = age;
            Name = name;
        }

        public void Introduction()
        {
            Console.WriteLine($"Hi, I'm {Name} and I'm {age} years old");
        }
    }
}
