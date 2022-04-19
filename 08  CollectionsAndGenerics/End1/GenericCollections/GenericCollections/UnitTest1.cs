using Pets;
using Races;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace GenericCollections
{
    public class UnitTest1
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        [Fact]
        public void Sum_Numbers_1_to_10()
        {
           // Do a foreach loop across all the elements in the 'numbers' list
           // and sum the total
           int total = 0;
           foreach (int i in numbers)
           {
               total += i;
           }
           Assert.Equal(55, total);
        }

        [Fact]
        public void Sum_Numbers_1_to_10_Easier()
        {
           // There is no code to add here, just note the easier way of doing the previous test
           Assert.Equal(55, numbers.Sum());
        }

        [Fact]
        public void Marathon_Dictionary()
        {
           // In this test project, create 2 new classes - Race and Runner (as in runners in a marathon)
           // Populate them like this

           // Runner has an overloaded ctor taking an int number and a string name
           // It also has a public property Charity that is optionally set

           // Race contains a dictionary of runners keyed by their number
           // It also contains a method GetWinner(int) where you give it a number and it returns the Runner

           Race londonMarathon = new Race();
           londonMarathon.Add(new Runner(537, "Donald Trump") { Charity = "n/a" });
           londonMarathon.Add(new Runner(2071, "Nicola Sturgeon") { Charity = "The Krankies" });
           londonMarathon.Add(new Runner(125, "Boris Johnson") { Charity = "Hairspray" });

           Runner winner = londonMarathon.GetWinner(2071);
           Assert.Equal("The Krankies", winner.Charity);
        }

        [Fact]
        public void Battersea_Dogs_Home()
        {
           // In this test project, create 2 new classes Dog and DogsHome
           // Populate them like this

           // Dog has an overloaded ctor taking a string name and int age
           // and exposing readonly properties of these

           // DogsHome contains a Dictionay keyed by dogs name, but it can have
           // many dogs which have the same name
           // It has a method GetDogsCalled(string) where you pass in the name
           // and it returns a list of Dogs all with that name

           DogsHome battersea = new DogsHome();
           battersea.Add(new Dog("Rover", 5));
           battersea.Add(new Dog("Bonzo", 6));
           battersea.Add(new Dog("Edna", 7));
           battersea.Add(new Dog("Bonzo", 8));
           battersea.Add(new Dog("Rover", 9));

           Assert.Equal(2, battersea.GetDogsCalled("Rover").Count);
        }

        // ##############
        // ## OPTIONAL ##
        // ##############
        [Fact]
        public void Get_Ranges()
        {
            // Fill in where the question marks are
            int thirdFromEnd = numbers[^3];
            Assert.Equal(8, thirdFromEnd);

            int[] slice_34567 = numbers.ToArray()[2..^3];
            Assert.Equal(25, slice_34567.Sum());

            int[] slice_1234567 = numbers.ToArray()[..^3];
            Assert.Equal(28, slice_1234567.Sum());

            int[] slice_345678910 = numbers.ToArray()[2..];
            Assert.Equal(52, slice_345678910.Sum());

            int[] slice_12345678910 = numbers.ToArray()[..];
            Assert.Equal(55, slice_12345678910.Sum());
        }
    }
}
