using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Methods
{
    class Notifier
    {
        public static void Notify(string Title,string Message,string TextColor = "Black",string BackGroundColor = "White")
        {
            Console.WriteLine("Text Color : {0} BackGroundColor : {1}",TextColor,BackGroundColor);
            Console.WriteLine("Titel : {0}, Message : {1}",Title,Message);
        }
    }
}
