using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class MyGenericList<T>
    {
        private ArrayList list = new ArrayList();

        public void Add(T t)
        {
            list.Add(t);
        }

        public T Get(int index)
        {
            return (T)list?[index];
        }
    }
}
