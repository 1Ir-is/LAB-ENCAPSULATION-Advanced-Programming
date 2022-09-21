using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ENCAPSULATION
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.salary = salary;
        }

        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            set 
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                lastName = value; 
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                age = value;
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set 
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
                salary = value; 
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age > 30)
            {
                salary += salary * percentage / 100;
            }
            else
            {
                salary += salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is {this.age} years old and the salary is {this.salary} leva";
        }
    }
}
