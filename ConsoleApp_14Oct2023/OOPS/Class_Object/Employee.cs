using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS.Class_Object
{
    //User define data type
    //if you did not create any constructor inside a class,
    //then by default a default cnstructor is created by compiler.
    class Employee
    {
        public static string OrganizationName;
        public int EmpId;
        public string Name;

        public Employee()
        {
            Console.WriteLine("Default Contructor Invoked!");
            EmpId = 100;
            Name = null;
        }

        public Employee(int Id,string Name)
        {
            Console.WriteLine("Parameterized Contructor Invoked!");
            EmpId = Id;
            this.Name = Name;
        }

        public Employee(Employee employee)
        {
            Console.WriteLine("Copy Contructor Invoked!");
            EmpId = employee.EmpId;
            Name = employee.Name;
        }

        static Employee()
        {
            Console.WriteLine("Static Contructor Invoked!");
            OrganizationName = "Abc Pvt. Ltd.";
        }
    }
}
