using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023
{
    class Program
    {
        public readonly int _readonly = 10;
        public const int _constant = 20;
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.b = 10;

            
            Console.WriteLine($"program readonly  : {program._readonly}");
            Console.WriteLine($"program2 constant  : {_constant}");
        }
    }
}
