using System;
using System.Collections.Generic;
using System.Text;

namespace Pets
{
    public class DogsHome
    {
        Dictionary<string, List<Dog>> groupsOfDogsByName = new Dictionary<string, List<Dog>>();

        public void Add(Dog d)
        {
            if (!groupsOfDogsByName.ContainsKey(d.Name))
            {
                groupsOfDogsByName.Add(d.Name, new List<Dog>());
            }
            groupsOfDogsByName[d.Name].Add(d);
        }

        public List<Dog> GetDogsCalled(string name)
        {
            return groupsOfDogsByName?[name];
        }
    }
}
