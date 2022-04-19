using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class MyListOfRubbish
    {
        // ArrayList is a collection class that existed in C# before generics were invented
        // You can add anything to it and hence what you get out is, well, anything
        private ArrayList list = new ArrayList();

        public void Add(object o)
        {
            list.Add(o);
        }

        public object Get(int index)
        {
            return list?[index];
        }
    }
}
