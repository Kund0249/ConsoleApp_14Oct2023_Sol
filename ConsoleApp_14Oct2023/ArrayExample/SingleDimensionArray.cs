using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_14Oct2023.Methods;

namespace ConsoleApp_14Oct2023.ArrayExample
{
    class SingleDimensionArray
    {
        static void Main(string[] args)
        {
            //int[] Numbers = new int[5] { 1, 2, 3, 4, 5 };

            int[] Numbers = new int[5];
            Numbers[0] = 10;

            // new MathClient().Add(Numbers);

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write(Numbers[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
