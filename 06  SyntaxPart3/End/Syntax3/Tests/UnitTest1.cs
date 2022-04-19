using Syntax3;
using System;
using Xunit;
using static Syntax3.Make;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Value_And_Reference_Types()
        {
            // Create a a new public type LatLon in the Syntax2 project
            // Generate properties Lat and Lon
            LatLon london = new LatLon() { Lat = 51.0, Lon = 0.0 };
            LatLon bristol = london;
            bristol.Lon -= 2.0;

            Assert.True(london.Lat == 51.0);
            Assert.True(london.Lon == 0.0); // if this fails, did you create a class or a struct?

            Assert.True(bristol.Lat == 51.0);
            Assert.True(bristol.Lon == -2.0);
        }

        [Fact]
        public void Null_Reference()
        {
            // Generate new type Car
            Car c = null;
            //bool started = c.Start(); // Generate method and delete 'throw new NotImplementedException();'

            // Put in a not-null test around the above
            bool started = false;
            if (c != null)
            {
                started = c.Start();
            }
            Assert.False(started);
        }

        [Fact]
        public void Null_Reference_Resolve_By_Elvis()
        {
            Car c = null;
            //bool started = c.Start();
            // Do the same as the previous test but using the Elvis operator
            bool? started = c?.Start();
            Assert.Null(started);
        }

        [Fact]
        public void Try_Parse_Succeeds()
        {
            string input = "42";
            int result;
            // insert a call to TryParse
            int.TryParse(input, out result);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Try_Parse_Fails()
        {
            string input = "42X";
            int result;
            // Nothing to do on this test!!
            Assert.False(int.TryParse(input, out result));
        }

        [Fact]
        public void Statics()
        {
            int startCount = Car.Count;

            for (int i = 0; i < 42; i++)
            {
                new Car();
            }
            // Add a static int property Count with a public getter and a private setter which is incremented in the Car ctor
            // You will need to do this manually - Ctrl+dot won't help you
            Assert.Equal(42, Car.Count - startCount);
        }

        [Fact]
        public void Enums()
        {
            // Get this to compile (hints: enums and 'using static')
            // Again, the Visual Studio refactoring tools won't help you
            Car c = new Car() { Make = Ford };
            Assert.Equal(Ford, c.Make);
        }

        // Create a folder named FromDatabase in your Syntax2 project
        // Create a partial class Car in there with the same namespace as the Car at the project level
        // Make the Car at the project level also a partial class
        // Move the Make to the 'FromDatabase' Car and add a string RegNumber
        // The following should then compile

        // We do this such that we could completely reconstruct the 'FromDatabase' bit of the Car class directly from the database 
        // to guarantee that its in sync
        [Fact]
        public void Partial_Classes()
        {
            Car c = new Car() { Make = Ford, RegNumber = "ABC 123" };
        }


        // We will do this in 2 stages
        // 1) Create an extension method that returns a hard-coded value
        // 2) Replace the hard-coded value with the proper code

        // Start by creating a public static class called ExtensionMethods in which you have an extension method (extending string) called GetLengthsAsNumber()
        // In your first stab just return the double 3.141592

        [Fact]
        public void Extension_Methods_And_Array1()
        {                   // 3.1  4   1   5      9      2
            string ditty = @"How I wish I could recollect pi";
            Assert.Equal(3.141592, ditty.GetLengthsAsNumber1());
        }

        // Now, if you have time, do the Full Monte
        // Then use the .Split() method on string to split it into an array of words
        // iterate round the words in the array, taking the length of each word
        // to convert 1,2,3 to one hundred and twenty three
        // ((1 * 10) + 2) * 10 + 3
        // You will need to do this in a loop
        // and finally reduce it from 3141592 to 3.141592 by multiplying by 10 to the minus x
        //  double powerOf10 = Math.Pow(10, -(words.Length - 1));
        //  number = number* powerOf10;
        //  double result = Math.Round(number, 6);

        // Don't be at all surprised if you need to look at the worked solution!!

        [Fact]
        public void Extension_Methods_And_Array2()
        {                   // 3.1  4   1   5      9      2
            string ditty = @"How I wish I could recollect pi";
            Assert.Equal(3.141592, ditty.GetLengthsAsNumber2());
        }

    }
}
