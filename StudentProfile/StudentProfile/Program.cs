using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //interface concept
    interface MY_INTERFACE
    {
        //int iAge; //cannot contains field
        //public void print(); //access modifier is not allowed
        //only declaration is allowed
        //no definition of member is allowed
        //by default members are PUBLIC in Interface
        void print();
    }

    public class Customer : MY_INTERFACE
    {
        public void print()
        {
            Console.WriteLine("interface print method implemented\n\n");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MY_INTERFACE m1 = new Customer();
            m1.print();

            Customer c1 = new Customer();
            c1.print();
        }
    }
}