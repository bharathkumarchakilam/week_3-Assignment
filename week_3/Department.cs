using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Manager
    {
        public string Name { get; set; }

        public Manager(string name)
        {
            Name = name;
        }
    }

    class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        // Shallow Copy
        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        // Deep Copy
        public Department DeepCopy()
        {
            return new Department(DepartmentName, new Manager(Manager.Name));
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DepartmentName}, Manager: {Manager.Name}");
        }
    }

    //class Program12
    //{
    //    static void Main()
    //    {
    //        Manager originalManager = new Manager("Alice");
    //        Department originalDepartment = new Department("HR", originalManager);

    //        // Shallow Copy
    //        Department shallowCopy = originalDepartment.ShallowCopy();

    //        // Deep Copy
    //        Department deepCopy = originalDepartment.DeepCopy();

    //        Console.WriteLine("Before Modification:");
    //        originalDepartment.Display();
    //        shallowCopy.Display();
    //        deepCopy.Display();

    //        // Modify original manager's name
    //        originalManager.Name = "Bob";

    //        Console.WriteLine("\nAfter Modifying Original Manager's Name:");
    //        originalDepartment.Display();
    //        shallowCopy.Display();
    //        deepCopy.Display(); // Deep copy remains unchanged
    //    }
    //}
}
