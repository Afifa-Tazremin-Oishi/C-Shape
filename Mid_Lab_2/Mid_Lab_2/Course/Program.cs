//A C# Program to simulate Course information among course objects.
using System;

namespace Course
{

    class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public Course()
        {

        }
        public Course(string n, string co, int cr)
        {
            courseName = n;
            courseCode = co;
            courseCredit = cr;
        }
        public string CourseName
        {
            get
            {
                return this.courseName;
            }
            set
            {
                this.courseName = value;
            }
        }
        public string CourseCode
        {
            get
            {
                return this.courseCode;
            }
            set
            {
                this.courseCode = value;
            }
        }

        public int CourseCredit
        {
            get
            {
                return this.courseCredit;
            }
            set
            {
                this.courseCredit = value;
            }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("\nCourse Information:\nName: " + CourseName);

            Console.WriteLine("Course Code: " + CourseCode);

            Console.WriteLine("Credit : " + CourseCredit);

        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Course C1 = new Course();
            C1.CourseName = "OOP2";
            C1.CourseCode = "CSC-21551";
            C1.CourseCredit = 3;
            C1.ShowCourseInfo();
            Course C2 = new Course("Web Technologies", "CSC-4500", 5);
            C2.ShowCourseInfo();
        }
    }
}
//Program Contributed by Mahmodul Ratul.