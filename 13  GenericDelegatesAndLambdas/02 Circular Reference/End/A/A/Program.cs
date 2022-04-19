using B;
using System;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            x.Method1( msg => Console.WriteLine("A.Callback " + msg) );
        }

        //private static void Callback(string msg)
        //{
        //    Console.WriteLine("A.Callback" + msg);
        //}
    }
}
