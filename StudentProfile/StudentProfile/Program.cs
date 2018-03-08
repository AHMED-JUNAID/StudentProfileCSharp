using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    //  method overloading

    class Program
    {
        public static void add(int fn, params int[] ln)
        {
            Console.WriteLine("sum = {0}", fn);
        }

        public static void add(int fn, int[] ln)
        {
            Console.WriteLine("sum = {0}", fn);
        }

       

        //public static void add(int fn, int ln, int tn)
        //{
        //    Console.WriteLine("sum = {0}", fn + ln + tn);
        //}

        //public static void add(int fn, int ln, out int sum)
        //{
        //    Console.WriteLine("sum = {0}", fn + ln );
        //    sum = fn + ln;
        //}


        static void Main(string[] args)
        {
           
        }
    }
}