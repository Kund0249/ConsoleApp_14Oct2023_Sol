using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.DelegatesExample
{
   

    class Startup
    {
        public void Meth1()
        {
            Console.WriteLine("Meth1 is Invoked!");
        }

        public static void Meth2()
        {
            Console.WriteLine("Meth2 is Invoked!");
        }

        public static void Meth3()
        {
            Console.WriteLine("Meth3 is Invoked!");
        }
       
        //public static bool IsEven(int n)
        //{
        //    if (n % 2 != 0)
        //        return true;
        //    return false;
        //}
        static void Main(string[] args)
        {
            //MyLogic logic = new MyLogic(x => x % 2 != 0);
            //new Repository().GetData(logic);

            new Repository().GetData(x => x < 5);
            
            //new Startup().Meth1();
            //MyDel del = new MyDel(new Startup().Meth1);
            //del += Meth2;
            //del += Meth3;

            //del.Invoke();
        }
    }
}
