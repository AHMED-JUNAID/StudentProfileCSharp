using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //abstract class concept
    public abstract class AbstractClass //abstract class cannot be sealed or static
    {
        public abstract void Print();
    }
   
    public class Customer : AbstractClass 
    {
        public override void Print()
        {
            Console.WriteLine("abstract print method implemented\n\n");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass obj = new Customer();
            obj.Print();
        }
    }
}