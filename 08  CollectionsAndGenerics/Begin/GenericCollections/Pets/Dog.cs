namespace Pets
{
    public class Dog
    {
        private string name;
        private int age;

        public string  Name { get; { return name; } }
        public int Age { get; { return age; } }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}