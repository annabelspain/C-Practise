using System;

namespace SyntaxPart1
{
    class Program
    {
        private static int dressSize;

        static void Main(string[] args)
        {                                                            // 1)
            double dressSize;
            dressSize = 12;                                            // 2)
            double salary = 50000.50;                                                   // 3)
            decimal pi = 3.14159M;                                                       // 4)
            decimal distanceToPlutoInMillimetres;                                       // 5)
            int iResult = 31 & 17;
            Console.WriteLine(iResult);// 6)


            long height = 200;
            int width = (int) height;                                                         // 7)

            double kerbWeight = 20000;
            double maxWeightPerAxle = 660;
            int requiredNumberOfAxles = (int)(kerbWeight / maxWeightPerAxle);             // 8)

            string programFiles = "c:\Program Files";                                   // 9)

                                                                                        // 10)
            string pmsAddress = @" 
                Boris Johnson
                10 Downing Street
                London
                SW1A 2AA";

            //int win1 = 42, win2 = 1, win3 = 5, win4 = 49, win5 = 33, win6 = 34;         
            //string lotteryNumbers = string.Format("The winning lottery numbers are {1}, {2}, {3}, {4}, {5}, {6}", win1, win2, win3, win4, win5, win6);      // 11)           
            //string moreLotteryNumbers = string.Format("Next weeks winning lottery numbers are {0}, {1}, {2}, {3}, {4}, {5}", win1, win2, win3, win4, win5); // 12)          
            //string evenMoreLotteryNumbers = "Next weeks winning lottery numbers are {win1}, {win2}, {win3}, {win4}, {win5}, {win6}";                        // 13)

            
            //bool bResult2 = Condition1() && Condition2(); // Put a breakpoint here and F11. Confirm it does short-circuit evaluation and never goes into Condition2() // 14)

        }

        static bool Condition1()
        {
            return false;
        }
        static bool Condition2()
        {
            return true;
        }

    }
}
