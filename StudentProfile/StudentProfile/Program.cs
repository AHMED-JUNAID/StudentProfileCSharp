using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    // Properties
    public class Student
    {
        private int ID;
        private string Name;
        private int PassMarks = 35;

        public void SetID(int ID)
        {
            if (ID < 0) //property of id that id should be greator than 0
            {
                throw new Exception("student id should not be -ve");
            }
            this.ID = ID;
        }

        public int GetID()
        {
            return this.ID;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name cannot be empty or null");
            }
            this.Name = Name;
        }

        public string GetName()
        {
            return string.IsNullOrEmpty(this.Name) ? "No Name" : this.Name;

            //if (string.IsNullOrEmpty(this.Name))
            //{
            //    return "No_Name";
            //}
            //return this.Name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student stuObj = new Student();
            stuObj.SetID(15);
            stuObj.SetName("Junaid Ahmed");

            Console.WriteLine(stuObj.GetID());
            Console.WriteLine(stuObj.GetName());
        }
    }
}