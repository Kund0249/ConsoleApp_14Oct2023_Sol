using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Generic
{
  
    class A
    {
        //boxing : Converting a value type into ref type
        public void Add(object V1,object V2)
        {
            //Unboxing : Converting a ref type into value type
            dynamic NewValue1 = V1;
            dynamic NewValue2 = V2;
            Console.WriteLine("Result : " + (NewValue1 + NewValue2));
        }


        public bool Compare<T>(T V1,T V2)
        {
            dynamic NewValue1 = V1;
            dynamic NewValue2 = V2;

            if (NewValue1 == NewValue2)
                return true;

            return false;
        }
    }
    class Startup
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new A().Compare("10","10"));
          
        }
    }
}
