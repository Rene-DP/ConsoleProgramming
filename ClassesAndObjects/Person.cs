using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Person
    {
        // Properties when public
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // Private - fields
        private double _salary { get; set; }
        public int _yearOfBirth { get; set; }

        public void setSalary(double salary)
        {
            _salary = salary;
        }

        public double getSalary()
        {
            return _salary;
        }

        public string getFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public string getFullName(string middleName)
        {
            return $"{FirstName} {middleName} {LastName}";
        }

        public void setYearOfBirth(int age, int month)
        {
            _yearOfBirth = DateTime.Now.Year - age;

            if (month > DateTime.Now.Month)
            {
                _yearOfBirth = _yearOfBirth - 1;
            }
        }

        public int getYearOfBirth()
        {
            return _yearOfBirth;
        }
    }
}
