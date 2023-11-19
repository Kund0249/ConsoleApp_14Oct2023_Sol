using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS.Polimorphism
{
   static class Calculator
    {
        public static int Add(int V1, int V2)
        {
            return (V1+V2);
        }

        //public static int Add(int V1, ref int V2)
        //{
        //    return (V1 + V2);
        //}

        //public static float Add(int V1,out int V2)
        //{
        //    V2 = 10;
        //    return 10.5F;
        //}

        public static int Add(int V1, int V2,int V3)
        {
            return (V1 + V2 + V3);
        }

        public static float Add(float V1, int V2)
        {
            return (V1 + V2);
        }

        public static float Add(int V1, float V2)
        {
            return (V1 + V2);
        }
    }
    class Startup
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Calculator.Add(10,10.5F));
            //Console.WriteLine("Hello");
            //Console.WriteLine(10);
            //Console.WriteLine(true);
            //Console.WriteLine(10.5F);
        }    
    }
}
