using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects

    // Primitive datatypes
    // int, string, char, bool

    // Object Oriented Programmin (OOP) Creating your own datatype
    // Class - blueprint

    // Single principle responsability
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            string middleName = string.Empty;

            Console.Write("Enter first name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter middle name: ");
            middleName = Console.ReadLine();

            Console.Write("Enter last name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter age: ");
            person.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter month of birth (number): ");
            int month = Convert.ToInt32(Console.ReadLine());

            person.setYearOfBirth(person.Age, month);

            Console.Write("Enter salary: ");
            double salary = Convert.ToInt32(Console.ReadLine());
            person.setSalary(salary);

            Console.WriteLine("\nFirst name is: " + person.FirstName);
            Console.WriteLine("Last name is: " + person.LastName);

            if (string.IsNullOrEmpty(middleName))
            {
                Console.WriteLine("Full Name is: " + person.getFullName());
            }
            else
            {
                Console.WriteLine("Full name is: " + person.getFullName(middleName));
            }

            Console.WriteLine("Age is: " + person.Age);
            Console.WriteLine("Year of birth is: " + DateUtil.YearOfBirth(person.Age));
            Console.WriteLine("Year of birth is: " + person.getYearOfBirth());
            Console.WriteLine("Salary is: " + person.getSalary());

            Console.ReadKey();
        }
    }
}
