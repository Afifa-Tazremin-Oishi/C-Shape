using System;



namespace Course
{
    public class Course
    {
        private string courseName;
        private string courseCode;
        private int courseCredit;
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Input! Course name can't be blank");
                }
                else
                {
                    courseName = value;
                }
            }
        }
        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Invalid Input! Course name can't be blank");
                }
                else
                {
                    courseCode = value;
                }
            }
        }
        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid Credit!");
                }
                else
                {
                    courseCredit = value;
                }



            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();
            Console.Write("Enter your course name: ");
            c.CourseName = Console.ReadLine();
            Console.Write("Enter your course code: ");
            c.CourseCode = Console.ReadLine();
            Console.Write("Enter your course credit: ");
            c.CourseCredit = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();



        }
    }



}
