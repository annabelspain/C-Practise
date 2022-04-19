using System;
using System.Collections.Generic;
using System.Text;

namespace DI2
{
    public interface ILog
    {
        void Write(string msg);
    }


    public class ConsoleLog  : ILog
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }


    public class DatabaseLog : ILog
    {
        public void Write(string msg)
        {
            Console.WriteLine($"Write to database: {msg}");
        }
    }


}
