using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Generic
{
    class EmployeeEquilityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if (x.Id == y.Id && x.Name == y.Name)
                return true;

            return false;
        }

        public int GetHashCode(Employee obj)
        {
            //string value = obj.Id.ToString() + obj.Name;
            //int hashcode = value.GetHashCode();
            //return hashcode;
            return (obj.Id.ToString() + obj.Name).GetHashCode();
        }
    }
    class HashSet_Demo
    {
        static void Main(string[] args)
        {

            //Exclude the duplicate element from the collections
            //HashSet<int> NumberList = new HashSet<int>();
            //NumberList.Add(1);
            //NumberList.Add(2);
            //NumberList.Add(3);
            //NumberList.Add(4);
            //NumberList.Add(1);
            //NumberList.Add(2);
            //NumberList.Add(3);
            //NumberList.Add(4);

            //foreach (int item in NumberList)
            //{
            //    Console.WriteLine(item);
            //}

            HashSet<Employee> employees = new HashSet<Employee>(new EmployeeEquilityComparer());
            employees.Add(new Employee() { Id = 1, Name = "A" });
            employees.Add(new Employee() { Id = 2, Name = "B" });
            employees.Add(new Employee() { Id = 3, Name = "C" });
            employees.Add(new Employee() { Id = 4, Name = "D" });
            employees.Add(new Employee() { Id = 1, Name = "A" });
            employees.Add(new Employee() { Id = 2, Name = "B" });

            Employee employees1 = employees.FirstOrDefault(x => x.Id == 1);
            // employees.RemoveWhere(x => x.Id == 1);
            employees.Remove(employees1);

            foreach (Employee item in employees)
            {
                Console.WriteLine("Id : " + item.Id + " Name : " + item.Name);
            }

            //string N1 = "1Arpita";
            //string N2 = "2Arpita";

            //Console.WriteLine("HashCode of N1 : " + N1.GetHashCode());
            //Console.WriteLine("HashCode of N2 : " + N2.GetHashCode());
        }
    }
}
