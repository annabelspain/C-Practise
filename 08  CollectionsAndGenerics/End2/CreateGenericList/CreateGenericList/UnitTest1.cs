using Animals;
using System;
using Xunit;

namespace CreateGenericList
{
    public class UnitTest1
    {
        [Fact]
        public void Add_Dogs_And_Cats()
        {
            MyListOfRubbish lst = new MyListOfRubbish();
            lst.Add(new Dog());
            lst.Add(new Cat());
            Cat c = (Cat)lst.Get(1);
        }

        [Fact]
        public void Add_Just_Dogs()
        {
            MyGenericList<Dog> lst = new MyGenericList<Dog>();
            lst.Add(new Dog());
            //lst.Add(new Cat());  // <=== Fails on compile
            Dog k9 = lst.Get(0);
        }
    }
}
