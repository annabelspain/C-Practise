using System;

namespace Averages
{
    class programme
    {
        static void Main(string[] agrs)
        {
            AverageCalculator calculator = new AverageCalculator();
            calculator.AveragesWithWhile();
            Console.WriteLine("==========");
            calculator.AveragesWithDoWhile();
            Console.WriteLine("==========");
            calculator.AveragesWithFor();

        }
    }
}
