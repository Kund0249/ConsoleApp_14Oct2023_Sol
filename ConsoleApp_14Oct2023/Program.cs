using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023
{
    class Program
    {
        int b;
        public void Funcion1(int a)
        {
            b = 10;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.b = 10;

            Program program2 = new Program();
            program2.b = 20;

            Console.WriteLine($"program instance b : {program.b}");
            Console.WriteLine($"program2 instance b : {program2.b}");
        }
    }
}
