using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public class Person : IEquatable<Person>, IComparable<Person> /*, ICloneable*/, ICloneable<Person>
    {
        public string Name { get; }
        public string Address { get; }
        public DateTime Dob { get; }

        public Person(string name, string address, DateTime dob)
        {
            Name = name;
            Address = address;
            Dob = dob;
        }

        public bool Equals(Person other)
        {
            return (
                this.Name == other.Name &&
                this.Address == other.Address &&
                this.Dob == other.Dob
                );
        }

        public int CompareTo(Person other)
        {
            if (this.Dob > other.Dob) return 1;
            if (this.Dob < other.Dob) return -1;
            return 0;
        }

        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }

        //public object Clone()
        //{
        //    return this.MemberwiseClone();
        //}
    }
}
