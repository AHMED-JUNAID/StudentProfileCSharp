using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    // auto-implemented Properties C#
    public class Student
    {
        private int ID;
        private string Name;
        private int PassMarks = 35;

        //auto-implemented properties code
        public string Email
        {
            /*
             * by using this compiler auto create private field for email
             * use when no logic is required
             * simple set the value and get the value without logic
             * then this method is best
             * */
            get;
            set;
        }

        //or write like this
        public string City { get; set; }//another way to write property(auto-implemented)
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student stuObj = new Student();
            stuObj.Email = "jdpakistani@gmail.com";
            Console.WriteLine(stuObj.Email);
        }
    }
}