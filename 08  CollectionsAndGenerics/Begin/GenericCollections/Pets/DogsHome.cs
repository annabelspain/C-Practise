using System;

namespace Pets
{
    public class DogsHome
    {
        public Dictionary<string, List<Dog>> Dogs = new Dictionary<string, List<Dog>>();

            public List<Dog> GetDogsCalled(string name)
        {
            return Dogs[name];
        }

        public void Add(Dog dog)
        {
            //Check if name exists in dictionary 
            if (Dogs.ConatinsKey(dog.Name))
            {
                //Add to existing list
                Dogs.Add(dog.Name, Dogs[dog.Name].Add(dog)); 
            }
            else
            {
                //Create new list 
                Dogs.Add(dog.Name, new List<Dog> { dog });
            }
            
        }
    }
}