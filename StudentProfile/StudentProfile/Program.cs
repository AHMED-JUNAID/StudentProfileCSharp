using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //struct concept
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

    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.ID = 123;
            c1.Name1 = "junaid";

            Console.WriteLine(c1.ID);
            Console.WriteLine(c1.Name1);

            Customer c2 = new Customer(456, "ahmed");
            Console.WriteLine(c2.ID);
            Console.WriteLine(c2.Name1);

            Customer c3 = new Customer
            {
                ID = 789, 
                Name1="akram"
            
            };

            Console.WriteLine(c3.ID);
            Console.WriteLine(c3.Name1);

        }
    }
}