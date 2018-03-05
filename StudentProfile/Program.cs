using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    class Student
    {
        private string studentId;
        private string studentName;
        private string studentSemester;
        private string studentCGPA;
        private string studentDepartment;
        private string studentUniversity;
        private string studentAttendance;

        public Student()
        {
            this.studentId = "null";
            this.studentName = "null";
            this.studentSemester = "null";
            this.studentCGPA = "null";
            this.studentDepartment = "null";
            this.studentUniversity = "null";
            this.studentAttendance = "null";
        }

        public void setStudentId(string studentId)
        {
            this.studentId = studentId;
        }

        public string getStudentId()
        {
            return this.studentId;
        }

        public void setStudentName(string studentName)
        {
            this.studentName = studentName;
        }

        public string getStudentName()
        {
            return this.studentName;
        }

        public void setStudentSemester(string studentSemester)
        {
            this.studentSemester = studentSemester;
        }

        public string getStudentSemester()
        {
            return this.studentSemester;
        }

        public void setStudentCGPA(string studentCGPA)
        {
            this.studentCGPA = studentCGPA;
        }

        public string getStudentCGPA()
        {
            return this.studentCGPA;
        }

        public void setStudentDepartment(string studentDepartment)
        {
            this.studentDepartment = studentDepartment;
        }

        public string getStudentDepartment()
        {
            return this.studentDepartment;
        }

        public void setStudentUniversity(string studentUniversity)
        {
            this.studentUniversity = studentUniversity;
        }

        public string getStudentUniversity()
        {
            return this.studentUniversity;
        }

        public bool isStudentIdExist(string searchStudentId, string pathOfStudentDataBase)
        {
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string existStudentId = null;
                while ((existStudentId = readFileObj.ReadLine()) != null)
                {
                    if (existStudentId.Equals(searchStudentId))
                        return false;
                    for (int i = 0; i < 6; i++)
                        readFileObj.ReadLine();
                }
            }
            return true;
        }

        public void writeToStudentDataBase(string pathOfStudentDataBase)
        {
            using (StreamWriter writeFileObj = new StreamWriter(pathOfStudentDataBase, true))
            {
                writeFileObj.WriteLine(this.studentId);
                writeFileObj.WriteLine(this.studentName);
                writeFileObj.WriteLine(this.studentSemester);
                writeFileObj.WriteLine(this.studentCGPA);
                writeFileObj.WriteLine(this.studentDepartment);
                writeFileObj.WriteLine(this.studentUniversity);
                writeFileObj.WriteLine(this.studentAttendance);
            }
        }

        public void showStudentDetails()
        {
            Console.WriteLine("\n\n\t\tStudent ID         : " + this.studentId);
            Console.WriteLine("\n\t\tStudent Name       : " + this.studentName);
            Console.WriteLine("\n\t\tStudent Semester   : " + this.studentSemester);
            Console.WriteLine("\n\t\tStudent CGPA       : " + this.studentCGPA);
            Console.WriteLine("\n\t\tStudent Department : " + this.studentDepartment);
            Console.WriteLine("\n\t\tStudent University : " + this.studentUniversity);
            Console.WriteLine();
        }

        public bool searchByStudentId(string studentId, string pathOfStudentDataBase)
        {
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentId.Equals(studentId))
                    {
                        showStudentDetails();
                        return true;
                    }
                }
            }

            return false;
        }

        public bool searchByStudentName(string studentName, string pathOfStudentDataBase)
        {
            int counter = 0;
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentName.Equals(studentName))
                    {
                        showStudentDetails();
                        counter++;
                    }
                }
            }

            if (counter > 0)
                return true;
            else
                return false;
        }

        public bool searchByStudentSemester(string studentSemester, string pathOfStudentDataBase)
        {
            int counter = 0;
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentSemester.Equals(studentSemester))
                    {
                        showStudentDetails();
                        counter++;
                    }
                }
            }

            if (counter > 0)
                return true;
            else
                return false;
        }

        public bool deleteStudentRecord(string studentId, string pathOfStudentDataBase)
        {
            int counter = 0;
            List<string> stringList = new List<string>();

            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentId.Equals(studentId))
                    {
                        counter++;
                    }
                    else
                    {
                        stringList.Add(this.studentId);
                        stringList.Add(this.studentName);
                        stringList.Add(this.studentSemester);
                        stringList.Add(this.studentCGPA);
                        stringList.Add(this.studentDepartment);
                        stringList.Add(this.studentUniversity);
                        stringList.Add(this.studentAttendance);
                    }
                }
            }

            using (StreamWriter writeFileObj = new StreamWriter(pathOfStudentDataBase))
            {
                foreach (string readFromList in stringList)
                {
                    writeFileObj.WriteLine(readFromList);
                }
            }

            if (counter > 0)
                return true;
            else
                return false;
        }

        public bool topThreeOfSemester(string studentSemester, string pathOfStudentDataBase)
        {
            List<string> stringList = new List<string>();
            int numberOfItemsInList = 0;

            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                for (int i = 0; i < 2; i++)
                    readFileObj.ReadLine();

                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentSemester = readString;
                    this.studentCGPA = readFileObj.ReadLine();

                    if(this.studentSemester.Equals(studentSemester))
                        stringList.Add(this.studentCGPA);

                    for (int i = 0; i < 5; i++)
                        readFileObj.ReadLine();
                }
            }

            stringList.Sort();
            numberOfItemsInList = stringList.Count();
            string highestCGPA = null;
            string secondHighestCGPA = null;
            string thirdHighestCGPA = null;

            if (numberOfItemsInList >= 3)
            {
                highestCGPA = stringList[numberOfItemsInList - 1];
                secondHighestCGPA = stringList[numberOfItemsInList - 2];
                thirdHighestCGPA = stringList[numberOfItemsInList - 3];
            }
            else if (numberOfItemsInList == 2)
            {
                highestCGPA = stringList[numberOfItemsInList - 1];
                secondHighestCGPA = stringList[numberOfItemsInList - 2];
            }
            else if (numberOfItemsInList == 1)
            {
                highestCGPA = stringList[numberOfItemsInList - 1];
            }
            else
            {
                return false;
            }

            searchByStudentCGPA(highestCGPA, pathOfStudentDataBase);
            searchByStudentCGPA(secondHighestCGPA, pathOfStudentDataBase);
            searchByStudentCGPA(thirdHighestCGPA, pathOfStudentDataBase);

            return true;
            
        }

        public void searchByStudentCGPA(string studentCGPA, string pathOfStudentDataBase)
        {
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentCGPA.Equals(studentCGPA))
                    {
                        showStudentDetails();
                    }
                }
            }
        }

        public void markStudentAttendance(string studentSemester, string pathOfStudentDataBase)
        {
            List<string> markedAttendanceList = new List<string>();
            List<string> unMarkedAttendanceList = new List<string>();

            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentSemester.Equals(studentSemester))
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\t\tP - Present");
                        Console.WriteLine("\n\t\tA - Absent");
                        Console.Write("\n\n\t\tIs " + this.studentName + " Present ? ");
                        string attendance = Console.ReadLine().ToLower();

                        if (attendance.Equals("p"))
                            this.studentAttendance = "Present";
                        else
                            this.studentAttendance = "Absent";

                        markedAttendanceList.Add(this.studentId);
                        markedAttendanceList.Add(this.studentName);
                        markedAttendanceList.Add(this.studentSemester);
                        markedAttendanceList.Add(this.studentCGPA);
                        markedAttendanceList.Add(this.studentDepartment);
                        markedAttendanceList.Add(this.studentUniversity);
                        markedAttendanceList.Add(this.studentAttendance);
                    }
                    else
                    {
                        unMarkedAttendanceList.Add(this.studentId);
                        unMarkedAttendanceList.Add(this.studentName);
                        unMarkedAttendanceList.Add(this.studentSemester);
                        unMarkedAttendanceList.Add(this.studentCGPA);
                        unMarkedAttendanceList.Add(this.studentDepartment);
                        unMarkedAttendanceList.Add(this.studentUniversity);
                        unMarkedAttendanceList.Add(this.studentAttendance);
                    }
                }
            }

            using (StreamWriter writeFileObj = new StreamWriter(pathOfStudentDataBase))
            {
                foreach (string readFromList in markedAttendanceList)
                {
                    writeFileObj.WriteLine(readFromList);
                }
            }

            using (StreamWriter writeFileObj = new StreamWriter(pathOfStudentDataBase,true))
            {
                foreach (string readFromList in unMarkedAttendanceList)
                {
                    writeFileObj.WriteLine(readFromList);
                }
            }
        }

        public void viewStudentAttendance(string studentSemester, string pathOfStudentDataBase)
        {
            using (StreamReader readFileObj = new StreamReader(pathOfStudentDataBase))
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(" Student-ID |     Student-Name     |   Student-Attendance  ");
                Console.WriteLine("-----------------------------------------------------------");
                string readString = null;
                while ((readString = readFileObj.ReadLine()) != null)
                {
                    this.studentId = readString;
                    this.studentName = readFileObj.ReadLine();
                    this.studentSemester = readFileObj.ReadLine();
                    this.studentCGPA = readFileObj.ReadLine();
                    this.studentDepartment = readFileObj.ReadLine();
                    this.studentUniversity = readFileObj.ReadLine();
                    this.studentAttendance = readFileObj.ReadLine();

                    if (this.studentSemester.Equals(studentSemester))
                    {
                        Console.WriteLine(String.Format("   {0,-8} |  {1,-20}|     {2,5}", this.studentId, this.studentName, this.studentAttendance));
                    }
                }
                Console.WriteLine("-----------------------------------------------------------");
            }
        }

        public void thanksForUsingThisSystem()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\t\t\tTHANKS FOR USING THIS SYSTEM");
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student studentObj = new Student();
            //string pathOfStudentDataBase = @"C:\Users\JUNAID\Desktop\hello.txt";
            string pathOfStudentDataBase = args[0];
            string choice = null;
            bool tryAgain = true;

            while (tryAgain)
            {

                Console.WriteLine("\n\n\n\n\t\t\t1 - Create Student Profile");
                Console.WriteLine("\n\t\t\t2 - Search Student Record");
                Console.WriteLine("\n\t\t\t3 - Delete Student Record");
                Console.WriteLine("\n\t\t\t4 - Top 3 Of Semester");
                Console.WriteLine("\n\t\t\t5 - Mark Student Attendance");
                Console.WriteLine("\n\t\t\t6 - View Student Attendance");

                Console.Write("\n\n\t\t\tPlease Enter Your Choice : ");
                choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        {
                            string studentId = null;
                            string studentName = null;
                            string studentSemester = null;
                            string studentCGPA = null;
                            string studentDepartment = null;
                            string studentUniversity = null;

                            while (true)
                            {
                                Console.Clear();
                                Console.Write("\n\n\t\tPlease Enter Unique Student ID : ");
                                studentId = Console.ReadLine();
                                if (studentObj.isStudentIdExist(studentId, pathOfStudentDataBase))
                                {
                                    studentObj.setStudentId(studentId);
                                    break;
                                }
                            }

                            Console.Write("\n\n\t\tPlease Enter Student Name : ");
                            studentName = Console.ReadLine();
                            studentObj.setStudentName(studentName);

                            Console.Write("\n\n\t\tPlease Enter Student Semester : ");
                            studentSemester = Console.ReadLine();
                            studentObj.setStudentSemester(studentSemester);

                            Console.Write("\n\n\t\tPlease Enter Student CGPA : ");
                            studentCGPA = Console.ReadLine();
                            studentObj.setStudentCGPA(studentCGPA);

                            Console.Write("\n\n\t\tPlease Enter Student Department : ");
                            studentDepartment = Console.ReadLine();
                            studentObj.setStudentDepartment(studentDepartment);

                            Console.Write("\n\n\t\tPlease Enter Student University : ");
                            studentUniversity = Console.ReadLine();
                            studentObj.setStudentUniversity(studentUniversity);

                            studentObj.writeToStudentDataBase(pathOfStudentDataBase);

                            break;
                        }
                    case "2":
                        {
                            string studentId = null;
                            string studentName = null;
                            string studentSemester = null;

                            while (tryAgain)
                            {
                                Console.WriteLine("\n\n\n\n\t\t\t1 - Search By Student ID");
                                Console.WriteLine("\n\t\t\t2 - Search By Student Name");
                                Console.WriteLine("\n\t\t\t3 - Search By Student Semester");

                                choice = null;
                                Console.Write("\n\n\t\t\tPlease Enter Your Choice : ");
                                choice = Console.ReadLine();
                                Console.Clear();

                                switch (choice)
                                {
                                    case "1":
                                        {
                                            Console.Write("\n\n\t\t\tPlease Enter Student ID : ");
                                            studentId = Console.ReadLine();
                                            Console.Clear();

                                            if (studentObj.searchByStudentId(studentId, pathOfStudentDataBase))
                                                Console.WriteLine();
                                            else
                                                Console.WriteLine("\n\n\t\tNo Student Record Exist With This Student ID");

                                            break;
                                        }
                                    case "2":
                                        {
                                            Console.Write("\n\n\t\t\tPlease Enter Student Name : ");
                                            studentName = Console.ReadLine();
                                            Console.Clear();

                                            if (studentObj.searchByStudentName(studentName, pathOfStudentDataBase))
                                                Console.WriteLine();
                                            else
                                                Console.WriteLine("\n\n\t\tNo Student Record Exist With This Student Name");

                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.Write("\n\n\t\t\tPlease Enter Student Semester : ");
                                            studentSemester = Console.ReadLine();
                                            Console.Clear();

                                            if (studentObj.searchByStudentSemester(studentSemester, pathOfStudentDataBase))
                                                Console.WriteLine();
                                            else
                                                Console.WriteLine("\n\n\t\tNo Student Record Exist With This Student Semester");

                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("\n\n\t\tPlease Try Again And Choose Appropriate Choice! ");
                                            break;
                                        }
                                }
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\n\n\n\n\t\t\tDO YOU WANT SEARCH_MENU ? ");
                                Console.WriteLine("\n\t\t\tY - Continue");
                                Console.WriteLine("\n\t\t\tN - Exit");
                                Console.Write("\n\n\t\t\tPlease Enter Your Choice : ");

                                if (Console.ReadLine().ToLower().Equals("y"))
                                {
                                    tryAgain = true;
                                }
                                else
                                {
                                    break;
                                }
                                Console.Clear();
                            }

                            break;
                        }
                    case "3":
                        {
                            string studentId = null;

                            Console.Write("\n\n\t\t\tPlease Enter Student ID : ");
                            studentId = Console.ReadLine();
                            Console.Clear();

                            if (studentObj.deleteStudentRecord(studentId, pathOfStudentDataBase))
                                Console.WriteLine();
                            else
                                Console.WriteLine("\n\n\t\tNo Student Record Exist With This Student ID");

                            break;
                        }
                    case "4":
                        {
                            string studentSemester = null;

                            Console.Write("\n\n\t\t\tPlease Enter Student Semester : ");
                            studentSemester = Console.ReadLine();
                            Console.Clear();

                            if(studentObj.topThreeOfSemester(studentSemester, pathOfStudentDataBase))
                                Console.WriteLine();
                            else
                                Console.WriteLine("\n\n\t\tNo Student Record Exist With This Student Semester");

                            break;
                        }
                    case "5":
                        {
                            string studentSemester = null;

                            Console.Write("\n\n\t\t\tPlease Enter Student Semester : ");
                            studentSemester = Console.ReadLine();
                            Console.Clear();

                            studentObj.markStudentAttendance(studentSemester, pathOfStudentDataBase);

                            break;
                        }
                    case "6":
                        {
                            string studentSemester = null;

                            Console.Write("\n\n\t\t\tPlease Enter Student Semester : ");
                            studentSemester = Console.ReadLine();
                            Console.Clear();

                            studentObj.viewStudentAttendance(studentSemester, pathOfStudentDataBase);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n\n\t\tPlease Try Again And Choose Appropriate Choice! ");
                            break;
                        }
                }

                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tDO YOU WANT MAIN_MENU ? ");
                Console.WriteLine("\n\t\t\tY - Continue");
                Console.WriteLine("\n\t\t\tN - Exit");
                Console.Write("\n\n\t\t\tPlease Enter Your Choice : ");

                if (Console.ReadLine().ToLower().Equals("y"))
                {
                    tryAgain = true;
                }
                else
                {
                    Console.Clear();
                    studentObj.thanksForUsingThisSystem();
                    tryAgain = false;
                }
                Console.Clear();
            }
        }
    }
}