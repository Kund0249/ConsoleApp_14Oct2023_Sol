using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_14Oct2023.OOPS;

namespace ConsoleApp_14Oct2023.Methods
{
    class Startup
    {
        static void Main(string[] args)
        {
           

            MethodExample example = new MethodExample();

            #region Call By Value

            // example.Message("Kundan");
            // new MethodExample().Message("Kundan");


            //MethodExample.StaticMessage("Ajay");
            //int Value = 20;
            // Value = example.incrementor(Value); //call by Value
            //Value = 0;
            //Console.WriteLine("Value : " + Value);

            //int N = 5;
            //MathClient math = new MathClient();
            //bool IsNPrime = math.IsPrime(N);

            //if(IsNPrime)
            //    Console.WriteLine("{0} is a prime number",N);
            //else
            //    Console.WriteLine("{0} is not a prime number", N);
            #endregion

            #region Call By Ref

            int N = 0;
            example.Counter(ref N);

            Console.WriteLine("N = " + N);

            #endregion

        }
    }
}
