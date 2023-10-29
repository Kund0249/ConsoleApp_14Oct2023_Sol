using System;
using System.Threading;

namespace ConsoleApp_14Oct2023.ControlStatement.IterationStatement
{
    class forloop
    {
        static void Main(string[] args)
        {
           
            int Val = 11; //(1,5)
            bool IsPrime = true;

            Console.WriteLine("Start Time : " + DateTime.Now.ToLongTimeString());
            for (int i = 2; i < Val; i++)
            {
                //Thread.Sleep(2000);
                if (Val % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            Console.WriteLine("End Time : " + DateTime.Now.ToLongTimeString());

            if (IsPrime == true)
                Console.WriteLine($"{Val} is a Prime Number");
            else
                Console.WriteLine($"{Val} is not a Prime Number");
        }
    }
}
