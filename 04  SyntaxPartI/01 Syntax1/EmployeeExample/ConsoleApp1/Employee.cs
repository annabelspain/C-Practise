using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        //constructors
        public const decimal COMMISSION = 5.00M;
        public readonly decimal BONUS;

        //Prop + tab twice
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        //Full property: 

        //propf + tab twice 
        //instance variable, noone outside this class will be able to do anything with this
        private decimal salary;

        //Allows others access to get this but not change it
        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }


        //Constructors 
        public Employee() : this(5) //chain constructor 
        {
        }

        public Employee(int bonus)
        {
            BONUS = bonus;
            //get salary from database and set the salary 
            salary = GetSalary();
        }

        private decimal GetSalary()
        {
            //Go to the database and get the salary value 
            return 45.07M + COMMISSION + BONUS;
            //add salary to commisson and bonus
        }

    }
}
