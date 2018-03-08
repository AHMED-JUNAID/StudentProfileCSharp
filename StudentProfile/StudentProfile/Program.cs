using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //  Polymorphism concepts
    public class Employee
    {
        public string firstName = "junaid";
        public string lastName = "ahmed";

        public virtual void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "_PartTime");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + "_FullTime");
        }
        
    }

    public class TempEmployee : Employee
    {
        //public override void printFullName()
        //{
        //    Console.WriteLine(firstName + " " + lastName + "_TempTime");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] arrayOfEmp = new Employee[4];

            arrayOfEmp[0] = new Employee();
            arrayOfEmp[1] = new PartTimeEmployee();
            arrayOfEmp[2] = new FullTimeEmployee();
            arrayOfEmp[3] = new TempEmployee();

            foreach (Employee emp in arrayOfEmp)
            {
                emp.printFullName();
            }
            
        }
    }
}