using System;

namespace week_3
{
    class Student
    {
        string name;
        int rollNo;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                    Console.WriteLine("Name: " + name);
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                {
                    rollNo = value;
                    Console.WriteLine("Roll Number: " + rollNo);
                }
                else
                {
                    Console.WriteLine("Roll number cannot be negative");
                }
            }
        }
    }
    class Course
    {
        private string name;
        private int courseId;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                    Console.WriteLine("Course Name: " + name);
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
        public int CourseId
        {
            get { return courseId; }
            set
            {
                if (value > 0)
                {
                    courseId = value;
                    Console.WriteLine("Course Id: " + courseId);
                }
                else
                {
                    Console.WriteLine("Course Id cannot be negative");
                }
            }
        }
    }
    //class Program2
    //{
    //    static void Main()
    //    {
    //        Student student = new Student();
    //        student.Name = "John";
    //        student.RollNo = 101;
    //        Course course = new Course();
    //        course.Name = "C#";
    //        course.CourseId = 1;
    //    }
    //}
}