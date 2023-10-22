using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee("Kundan",29);
            
            Employee E2 = new Employee("Ajay", 28);
            Employee E3 = new Employee("Akshay", 27);

            E1.GetEmployee();
            E2.GetEmployee();
            E3.GetEmployee();
        }
    }
}
