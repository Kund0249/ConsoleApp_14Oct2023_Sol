using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kcorlib;

namespace ConsoleApp_14Oct2023.OOPS.Abstraction
{

    //public class EmailLogger : IEmailLogger
    //{
    //    public void Log(string To, string Message)
    //    {
    //        //code
    //        Console.WriteLine("Email is logged..");
    //    }
    //}

   public interface I1
    {
        void Foo();
    }

   public interface I2
    {
        void Foo();
    }

    class Abc : I1, I2
    {
        //implicitely
        public void Foo()
        {
            Console.WriteLine("Foo Method Invoked");
        }
       void I1.Foo()
        {
            Console.WriteLine("I1 Foo Method Invoked");
        }

        void I2.Foo()
        {
            Console.WriteLine("I2 Foo Method Invoked");
        }
    }
    class Startup : EmailService
    {
        static void Main(string[] args)
        {
            // Samsung samsung = new Samsung();

            //Mobile mobile = new Mobile();

            //EmailLogger email = new EmailLogger();
            //EmailService service = new EmailService(new EmailLogger());
            //service.Send("abc@gmail.com", "Hi");

            //Samsung samsung = new Samsung()
            //{
            //    Series = "M11"
            //};
            //samsung.AssembleMobile("1234", "2000000");

            //new Abc().Foo();

            //I1 i1 = new Abc();
            //I2 i2 = new Abc();

            //i2.Foo();

            Abc ob = new Abc();

            ((I1)ob).Foo();
            //((I2)ob).Foo();

            long a = 10;
            int b = (int)a;
        }
    }
}
