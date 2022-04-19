using System;

namespace B
{
    public class Class1
    {
        public void Method1(Action<string> action)
        {
            action("called from project B Method1");
        }
    }
}
