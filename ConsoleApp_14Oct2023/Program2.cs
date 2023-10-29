using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023
{
    class Program2
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine($"program readonly  : {program._readonly}");
            Console.WriteLine($"program2 constant  : {Program._constant}");
        }
    }
}
