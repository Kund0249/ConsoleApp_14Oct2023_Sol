using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kcorlib;

namespace ConsoleApp_14Oct2023.OOPS.Polimorphism
{
    //class MessageService
    //{
    //    //50+ Methods
    //    public virtual void Send(string To,string Message)
    //    {
    //        //code
    //        Console.WriteLine("Message Sent to : " + To);
    //    }
    //}

    //class CustomeMessageService : MessageService
    //{
    //    public override void Send(string To, string Message)
    //    {
    //        base.Send(To, Message);
    //        //Code
    //        Console.WriteLine("Message logged to DataBase.");
    //    }
    //}

    class Employee
    {
        public int Id;
        public string Name;

        public override string ToString()
        {
            return string.Format($"Id : {Id} Name : {Name}");
        }
    }
    class CustomeMessage : MessageService
    {
        public override void Send(string To, string Message)
        {
            base.Send(To, Message);
            //log
            Console.WriteLine("Message Logged");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            //MessageService messageService = new MessageService();
            //messageService.Send("7767543476", "Hi, How do you do?");

            //CustomeMessage service = new CustomeMessage();
            //service.Send("7767543476", "Hi, How do you do?");

            int N = 10;
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "John"
            };

          
            Console.WriteLine(N.ToString());
            Console.WriteLine(employee.ToString());
           
        }
    }
}
