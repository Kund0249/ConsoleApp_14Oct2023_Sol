using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_14Oct2023.OOPS.Inheritance;

namespace ConsoleApp_14Oct2023.OOPS
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Employee E1 = new Employee("Kundan",29);

            //Employee E2 = new Employee("Ajay", 28);
            //Employee E3 = new Employee("Akshay", 27);

            //E1.GetEmployee();
            //E2.GetEmployee();
            //E3.GetEmployee();
            //HomeLoan homeLoan = new HomeLoan();

            Encapsulation.Employee employee = new Encapsulation.Employee()
            {
                EmpId = 1,
                EmpName = "John",
                EmpSalary = 100
            };

            //OutPut.Print(10.5F);

            //Console.WriteLine($"Id : {employee.EmpId} Name : {employee.EmpName}");
            //employee.EmpId = 1;
            //employee.EmpName = "John";
            //employee.EmpSalary = 1000;
            //employee.EmpId(1);
            //employee.EmpName("John");
            //employee.EmpSalary(1000);



        }
    }
}
