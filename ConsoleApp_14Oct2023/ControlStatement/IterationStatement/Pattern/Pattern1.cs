using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ControlStatement.IterationStatement.Pattern
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("    *");
            //Console.WriteLine("   *@*");
            //Console.WriteLine("  *@*@*");
            //Console.WriteLine(" *@*@*@*");
            //Console.WriteLine("*@*@*@*@*");

            Console.Write("Enter Number of Line : ");
            int Line = Convert.ToInt32(Console.ReadLine());
            int Space = Line-1;
            int Star = 1;
            for (int i = 1; i <= Line; i++)//1
            {
                for (int j = 0; j < Space; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < Star; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Space--;
                Star += 2;
            }
        }
    }
}
