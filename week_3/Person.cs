using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method to be overridden by derived classes
        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Student1 : Person
    {
        public int StudentId { get; set; }

        public Student1(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Age: {Age}, Student ID: {StudentId}");
        }
    }

    class Teacher : Person
    {
        public string Subject { get; set; }

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }

    //class Program6
    //{
    //    static void Main()
    //    {
    //        Person person1 = new Student1("Alice", 20, 101);
    //        Person person2 = new Teacher("Mr. John", 45, "Mathematics");

    //        // Demonstrating polymorphism using base class reference
    //        Console.WriteLine("Details of Student:");
    //        person1.GetDetails();

    //        Console.WriteLine("\nDetails of Teacher:");
    //        person2.GetDetails();
    //    }
    //}
}
