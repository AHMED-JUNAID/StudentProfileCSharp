using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    // Method Hiding concepts
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public new void printFullName()
        {
            //base.printFullName();
            Console.WriteLine(firstName + " " + lastName + " Contractor");
        }
    }

    public class FullTimeEmployee : Employee
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee pte = new PartTimeEmployee();
            pte.firstName = "PartTime";
            pte.lastName = "Employee";
            pte.printFullName();
            
        }
    }
}