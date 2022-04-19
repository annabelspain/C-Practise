using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DisposeTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // ##################################################################
            // String does not have a Dispose() method. 
            // This section allocates strings up to the limit of available memory
            // and then throws an Out Of Memory Exception
            // Make a note of how approximately much memory its used
            // Note also that the List doubles its allocation each time it busts a limit
            // ##################################################################

            //List<string> aBigList = new List<string>();
            //while (true)
            //{
            //    aBigList.Add("abc");
            //    if ((aBigList.Count % 1000000) == 0)
            //    {
            //        Console.WriteLine($"Count={aBigList.Count}, Memory={GC.GetTotalMemory(false) / 1048576} Mb");
            //    }
            //}


            // ##################################################################
            // Pen does have a Dispose() method. 
            // Run it as is and you will see that it's slower (its grabbing Pens from the OS)
            // But when it runs out of Pens, it just hangs.
            // You can see that its still got bags of memory left - it hasn't run out of memory. Its run out of resources
            // Kill it, uncomment the call to Dispose() and run again
            // This simulates you using the resource & then declaring that you have no further use for it
            // This now goes much, much further and eventually throws an Out Of Memory Exception
            // ##################################################################

            //List<Pen> aBigList = new List<Pen> { };
            //while (true)
            //{
            //    Pen p = new Pen(Brushes.White);
            //    aBigList.Add(p);
            //    // p.Dispose();  // With this commented out, it just hangs
            //    if ((aBigList.Count % 1000000) == 0)
            //    {
            //        Console.WriteLine($"Count={aBigList.Count}, Memory={GC.GetTotalMemory(false) / 1048576} Mb");
            //    }
            //}



            // ##################################################################
            // This is the same as the above but pretend that an exception is thrown
            // Dispose is not called and we get the same behaviour as above - it hangs
            // But note how cripplingly slow exception handling is in .NET
            // ##################################################################

            //List<Pen> aBigList = new List<Pen> { };
            //while (true)
            //{
            //    try
            //    {
            //        Pen p = new Pen(Brushes.White);
            //        aBigList.Add(p);
            //        throw new Exception();
            //        p.Dispose();
            //    }
            //    catch { }
            //    if ((aBigList.Count % 1000000) == 0)
            //    {
            //        Console.WriteLine($"Count={aBigList.Count}, Memory={GC.GetTotalMemory(false) / 1048576} Mb");
            //    }
            //}



            // ##################################################################
            // This is the same as the above but now using the 'using' block
            // - a neater way of resolving the problem
            // ##################################################################
            //List<Pen> aBigList = new List<Pen> { };
            //while (true)
            //{
            //    try { 
            //    using (Pen p = new Pen(Brushes.White))
            //    {
            //        aBigList.Add(p);
            //        throw new Exception();
            //    }
            //    }
            //    catch { }
            //    if ((aBigList.Count % 1000000) == 0)
            //    {
            //        Console.WriteLine($"Count={aBigList.Count}, Memory={GC.GetTotalMemory(false) / 1048576} Mb");
            //    }
            //}

        }
    }
}
