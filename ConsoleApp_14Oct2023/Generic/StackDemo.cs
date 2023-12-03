using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Generic
{
    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack<int> stackitems = new Stack<int>();

            stackitems.Push(1);
            stackitems.Push(2);
            stackitems.Push(3);

            Console.WriteLine("Ready to remove : " + stackitems.Peek());
            //stackitems.Pop();

            foreach (int item in stackitems)
            {
                Console.WriteLine(item);
            }

        }
    }
}
