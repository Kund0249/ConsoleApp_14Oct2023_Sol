using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS.Polimorphism
{
   class EmailService
    {
        public void Send(string From,string To,string Body)
        {
            //code
        }

        public void Send(string From, string To, string Body,Base64FormattingOptions Attachement)
        {
            //code
        }

        public void Send(string From, string To,string Subject, string Body)
        {
            //code
        }

        public void Send(string From, string To, string Subject, string Body,string Signature)
        {
            //code
        }

        public void Send(string From, string To,string CC, string Subject, string Body, string Signature)
        {
            //code
        }

        public void Send(string From, string To, string CC, string Subject, string Body, string Signature,Base64FormattingOptions Attachement)
        {
            //code
        }

        public void Send(string From, string To, string CC, string Subject, string Body, string Signature, Base64FormattingOptions[] Attachement)
        {
            //code
        }

        public void Send(string From, string To, string CC,string BCC, string Subject, string Body, string Signature)
        {
            //code
        }

    }
    class MethodOverLoading_Demo
    {
        static void Main(string[] args)
        {

        }
    }
}
