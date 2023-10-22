using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS
{
    public class Employee
    {
         int EmpCode;
         string Name;
         int Age;

        static int Count = 0;

        public Employee(string Name,int Age)
        {
            this.Name = Name;
            this.Age = Age;
            EmpCode = ++Count;
        }

        public void GetEmployee()
        {
            Console.WriteLine($"EmpCode : {EmpCode} Name : {Name} Age : {Age}");
        }
    }
}
