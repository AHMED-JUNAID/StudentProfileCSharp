using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //  diff b/w method overriding and method hiding

    public class Base
    {
        public virtual void print()
        {
            Console.WriteLine("Base Class method");
        }
    }

    public class Derived : Base
    {
        public new void print()
        {
            Console.WriteLine("derived class method");
        }

        //public override void print()
        //{
        //    Console.WriteLine("derived class method");
        //}
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Derived();
            baseObj.print();
        }
    }
}