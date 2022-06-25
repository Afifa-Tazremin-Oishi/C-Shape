using System;



namespace Student
{
    class Student
    {
        private string name;
        private string id;
        private string department;



        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        throw new ArgumentException("Name cannot be blank.", "value");
                    }
                    name = value;
                }
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        // Report error                                        
                        // In C# 6.0 replace "value" with nameof(value)        
                        throw new ArgumentException("Id cannot be blank.", "value");
                    }
                    id = value;
                }
            }
        }




        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    value = value.Trim();
                    if (value == "")
                    {
                        // Report error                                        
                        // In C# 6.0 replace "value" with nameof(value)        
                        throw new ArgumentException("Department cannot be blank.", "value");
                    }
                    department = value;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student s = new Student();
                Console.Write("Enter Your Name: ");
                s.Name = Console.ReadLine();



                Console.Write("Enter Your ID: ");
                s.Id = Console.ReadLine();



                Console.Write("Enter Your Department Name: ");
                s.Department = Console.ReadLine();



                Console.WriteLine(" ");
                Console.WriteLine("##############STUDENT INFORMATION######### ");
                Console.WriteLine("Student Name  : " + s.Name);
                Console.WriteLine("Student Id    : " + s.Id);
                Console.WriteLine("Department    : " + s.Department);
                Console.ReadLine();



            }
        }
    }
}
