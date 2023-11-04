using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Methods
{
    class MethodExample
    {
        //access-specifiers return-type Name ([Paramater List])
        //{
        //body
        //}

        //Instance Method

        //public void incrementor(int Value)
        //{
        //    //code
        //    Value = Value + 5;
        //}


        #region Call By Value
        public int incrementor(int Value)
        {
            //code
            Value = Value + 5;
            return Value;
        }

        public void Message(string Name)
        {
            Console.WriteLine("Hello " + Name);
        }

        //Static Method
        public static void StaticMessage(string Name)
        {
            Console.WriteLine("Hello " + Name + ", From Static Method.");
        }

        #endregion

        #region Call By Ref
        public void Counter(ref int N)
        {
            N = N + 5;
        }
        #endregion

        //static void Main(string[] args)
        //{
        //    StaticMessage("Ajay");

        //    MethodExample example = new MethodExample();
        //    example.Message("Kundan");
        //}
    }
}
