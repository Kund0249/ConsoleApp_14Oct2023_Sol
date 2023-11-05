using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Methods
{
    class MathClient
    {
        public bool IsPrime(int Value)
        {
            for (int i = 2; i < Value/2; i++)
            {
                if(Value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void Rectangle(int Length,int Width,out int Paremeter,out int Area)
        {
             Paremeter = 2 * (Length + Width);
             Area = Length * Width;
            //Console.WriteLine("Paremeter : " + Paremeter);
            //Console.WriteLine("Area : " + Area);
            //return Area;
            //return Paremeter;
        }
       
        public bool ConvertToInt(string Value,out int Output)
        {
            try
            {
                Output = Convert.ToInt32(Value);
                return true;
            }
            catch (Exception)
            {
                Output = 0;
                return false;
            }
        }

        //public int Add(int[] Values)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Values.Length; i++)
        //    {
        //        Sum = Sum + Values[i];
        //    }
        //    return Sum;
        //}
        public int Add(params int[] Values)
        {
            int Sum = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                Sum = Sum + Values[i];
            }
            return Sum;
        }

    }
}
