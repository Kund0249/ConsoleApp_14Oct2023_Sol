using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023
{
    //User define DataType - Ref Type
   public class Employee
    {
       
        //Static Member Variable
        public static int Counter = 0;
        public static string Org;
        public Employee()
        {
            EmpCode = 0;
            Name = string.Empty;
            Age = 0;
            Counter = Counter + 1;
        }

        //Non-Static or Instance Member Variable
        public int EmpCode;
        public string Name;
        public byte Age;
       
    }

    public class Circle
    {
        //
        public readonly float PI;

        public Circle()
        {
            Radius = 1;
            PI = 3.14F;
        }

        public Circle(float Value)
        {
            Radius = 1;
            PI = Value;
        }

        //public const float PI = 3.14F;
      
        public int Radius;

        public float GetArea()
        {
           return 2 * PI * Radius;
        }

        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            //circle1.PI = 0;
            circle1.Radius = 5;

            Circle circle2 = new Circle(3.00F) {Radius = 10 };

            float Area = circle1.GetArea();

            Console.WriteLine("Area : " + Area);
            //Console.WriteLine("Area2 : " + circle2.GetArea());
        }

    }
    class TypesOfVariable
    {
        static void Main(string[] args)
        {
            //datatype ref Variable = object
            Employee E1 = new Employee();
            Employee E2 = new Employee();
            Employee E3 = new Employee();
            Employee E4 = new Employee();
          
            Console.WriteLine("Total Employee : " + Employee.Counter);
            //Console.WriteLine("EmpCode : " + E1.EmpCode + " Name : " + E1.Name + " Age : " + E1.Age);
            //Console.WriteLine("EmpCode : {0} Name : {1} Age : {2}",E1.EmpCode,E1.Name,E1.Age);
            //Console.WriteLine($"EmpCode : {E1.EmpCode} Name : {E1.Name} Age : {E1.Age}");
        }
    }
}
