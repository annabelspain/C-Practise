using Syntax3;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Value_And_Reference_Types()
        {
            // Create a a new public type LatLon in the Syntax3 project
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
            bool? started = false; // Generate method and delete 'throw new NotImplementedException();'
            // Put in a not-null test, so that the car is only started if there is a car
            started = c?.Start();
            Assert.False(started);
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
    }
}
