using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Cat : Animal
    {
        public override void Speaks()
        {
            Console.WriteLine("I am a Cat");

            base.Speaks();
        }
    }
}
