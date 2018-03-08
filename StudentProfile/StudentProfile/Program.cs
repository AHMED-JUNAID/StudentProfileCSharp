using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //diff b/w class and struct
    public struct Customer
    {
        private int Id;
        private string Name;

        

        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public string Name1
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }

       
    }

    public class Student
    {
        private int id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        ~Student()
        {
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(123, "actual");
            Customer c2 = c1;

            c2.ID = 456;
            c2.Name1 = "copy";

            //Console.WriteLine(c2.ID);
            //Console.WriteLine(c2.Name1);

            //Console.WriteLine(c1.ID);
            //Console.WriteLine(c1.Name1);

            Student s1 = new Student();
            s1.Id = 101;
            s1.Name = "class concept";

            Student s2 = new Student();
            s2 = s1;

            Console.WriteLine(s1.Id);
            Console.WriteLine(s1.Name);

            s2.Id = 901;
            s2.Name = "change effected";
            Console.WriteLine(s2.Id);
            Console.WriteLine(s2.Name);

            Console.WriteLine(s1.Id);
            Console.WriteLine(s1.Name);

        }
    }
}