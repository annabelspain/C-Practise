using System;
using System.Collections.Generic;
using System.Text;

namespace Races
{
    public class Runner
    {
        public int Number { get; }
        public string Name { get; }
        public string Charity { get; set; }

        public Runner(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
