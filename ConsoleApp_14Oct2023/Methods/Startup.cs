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
            MathClient client = new MathClient();

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

            //int N = 0;
            //example.Counter(ref N);

            //Console.WriteLine("N = " + N);

            #endregion

            #region Out Parameter
            //client.Rectangle(10,5,out int P,out int A);
            ////int P, A;
            ////A = P = 0;
            ////client.Rectangle(10, 5, ref P, ref A);
            //Console.WriteLine("Paremeter : {0} , Area : {1}",P,A);

            //if (client.ConvertToInt("10",out int Value))
            // {
            //     Console.WriteLine("Converted Value: " + Value);
            // }
            // else
            // {
            //     Console.WriteLine("Input string was not in correct format!");
            // }
            #endregion

            #region Params Array
            ////int[] Values = new int[3] { 10, 20, 30 };
            //int Res = client.Add(10,20,30,40,50);
            //Console.WriteLine("Result : "+ Res);
            #endregion

            #region Optional Parameter
            Notifier.Notify("Success", "Process Completed!",TextColor:"White",BackGroundColor:"Green");
            #endregion
        }
    }
}
