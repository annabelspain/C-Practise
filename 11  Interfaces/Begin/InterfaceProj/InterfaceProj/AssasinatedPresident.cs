using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public class AssasinatedPresident : Person, IComparable<AssasinatedPresident>
    {
        public DateTime Assasinated { get; }

        public AssasinatedPresident(string name, string address, DateTime dob, DateTime assasinated) : base(name, address, dob)
        {
            Assasinated = assasinated;
        }

        public int CompareTo(AssasinatedPresident other)
        {
            if (Assasinated.Month > other.Assasinated.Month)
                return 1;
            else if (Assasinated.Month < other.Assasinated.Month)
                return -1;
            else 
                return 0;
        }
    }
}
