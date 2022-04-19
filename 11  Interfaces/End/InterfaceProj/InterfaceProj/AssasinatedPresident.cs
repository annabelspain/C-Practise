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
            if (this.Assasinated.Month > other.Assasinated.Month) return 1;
            if (this.Assasinated.Month < other.Assasinated.Month) return -1;
            return 0;
        }
    }
}
