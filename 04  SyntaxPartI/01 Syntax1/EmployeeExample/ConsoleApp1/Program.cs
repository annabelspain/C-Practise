using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Create employee 
            Employee emp1 = new Employee();

            emp1.FirstName = "Olu";
            emp1.LastName = "Akins";
            emp1.Age = 2;
            //emp1.Salary = 67.9M;

            Console.WriteLine($"Emp1 {emp1.FirstName} {emp1.LastName} salary is {emp1.Salary}");

            //Create another employee 
            Employee emp2 = new Employee
            {
                FirstName = "Olu2",
                LastName = "Akins2",
                Age = 2
            };

        Console.WriteLine($"Emp2 {emp2.FirstName} {emp2.LastName} salary is {emp2.Salary}");

            //Create another employee 
            Employee emp3 = new Employee(25)
            {
                FirstName = "Olu3",
                LastName = "Akins3",
                Age = 2
            };

            Console.WriteLine($"Emp2 {emp3.FirstName} {emp3.LastName} salary is {emp3.Salary}");

        }
    }
}
