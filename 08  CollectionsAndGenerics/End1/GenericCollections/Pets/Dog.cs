using System;
using System.Collections.Generic;
using System.Text;

namespace Pets
{
    public class Dog
    {
        public string Name { get; }
        public int Age { get; }
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
