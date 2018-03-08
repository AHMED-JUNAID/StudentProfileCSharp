using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //Delegates
    /*
     * delegates are reference type
     * complicated subject but if u get command on basic then extremly easy
     * provide flexibility
     * delegate is a type safe function pointer
     * syntax of delegate is similar to function
     * to use delegate declare with delegate keyword
     */

    public delegate void helloDelegate(string msg);
    //this delegate can point to any function that have VOID return type
    //and same parameters. you can say same Signature

    class Program
    {
        public static void hello(string msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            helloDelegate delegat = new helloDelegate(hello);
            delegat("hello from delegate");
        }
    }
}