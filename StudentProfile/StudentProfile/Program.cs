using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    // inheritance concepts
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class Constructor");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("derived class controlling parent class")
        {
            Console.WriteLine("Child Class Constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
        }
    }
}