using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //problems of multiple inheritance

    interface A
    {
        void printA();
    }

    interface B 
    {
        void printB();
    }

    public class C : A,B
    {
        public void printA()
        {
            Console.WriteLine("class C implemented class A");
        }

        public void printB()
        {
            Console.WriteLine("class C implemented class B");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            C ob = new C();
            ob.printA();
            ob.printB();
        }
    }
}