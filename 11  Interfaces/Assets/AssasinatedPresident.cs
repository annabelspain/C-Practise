using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProj
{
    public class AssasinatedPresident : Person
    {
        public DateTime Assasinated { get; }

        public AssasinatedPresident(string name, string address, DateTime dob, DateTime assasinated) : base(name, address, dob)
        {
            Assasinated = assasinated;
        }

    }
}
