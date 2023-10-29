using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ControlStatement.IterationStatement
{
    class WhileLoopDemo
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter Value : ");
            int Val = Convert.ToInt32(Console.ReadLine()); 
                             // 1234%10 = 4 , 1234/10 = 123
                             //123 = 123%10 = 3, 123/10 = 12
                             //12 = 12%10 = 2, 12/10 = 1
                             //1 = 1%10 = 1, 1/10 = 0
            int Rev = 0;
            //while (Val > 0)
            //{
            //    int Rem = Val % 10;
            //    Rev = Rev * 10 + Rem;//4321
            //    Val = Val / 10;
            //}
            for (int i = Val; i > 0;)
            {
                int Rem = i % 10;
                Rev = Rev * 10 + Rem;
                i = i / 10;
            }

            Console.WriteLine("Rev : " + Rev);
        }
    }
}
