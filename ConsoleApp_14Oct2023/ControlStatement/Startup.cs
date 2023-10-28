using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ControlStatement
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int Val = Convert.ToInt32(Console.ReadLine()); //"1004"



            if (Val > 0)
            {
                Console.WriteLine($"{Val} is +ve");
                Console.WriteLine("Program competed!");
            }
            else if (Val < 0)
                Console.WriteLine($"{Val} is -ve");
            else
                Console.WriteLine($"{Val} neither +ve nor -ve");
        }
    }
}
