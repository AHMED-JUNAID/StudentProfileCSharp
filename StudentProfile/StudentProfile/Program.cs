using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //problems of multiple inheritance

    public class A
    {
        public virtual void print()
        {
            Console.WriteLine("class A ");
        }
    }

    public class B : A
    {
        public override void print()
        {
            Console.WriteLine("class B");
        }
    }

    public class C : A
    {
        public override void print()
        {
            Console.WriteLine("class C");
        }
    }

    public class D : B, C
    {
        //this is an ambiguity called Diamond problem
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            D ob = new D();
            ob.print(); //which override method called ...!!!!
        }
    }
}