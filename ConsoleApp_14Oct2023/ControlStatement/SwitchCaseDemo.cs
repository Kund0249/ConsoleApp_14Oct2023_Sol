using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ControlStatement
{
    class SwitchCaseDemo
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value 1 : ");
            int V1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value 2 : ");
            int V2 = int.Parse(Console.ReadLine());

            switch (V1 > V2)
            {
                case true:
                    Console.WriteLine("V1 is greater");
                    break;
                case false:
                    Console.WriteLine("V2 is greater");
                    break;
                default:
                    break;
            }

            //OperatorInput: //Lable
            //Console.Write("select => [+ , - , / , *] : ");

            //char _operator = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //if(_operator == '+')
            //    Console.WriteLine("Result : {0}", (V1 + V2));
            //else if(_operator == '-')
            //    Console.WriteLine("Result : {0}", (V1 - V2));
            //else if (_operator == '/')
            //    Console.WriteLine("Result : {0}", (V1 / V2));
            //else if (_operator == '*')
            //    Console.WriteLine("Result : {0}", (V1 * V2));
            //else
            //{
            //    Console.WriteLine("Opps! incorrect input or operator entered!");
            //    goto OperatorInput;
            //}

            //switch (_operator)
            //{
            //    case '+':
            //        Console.WriteLine("Result : {0}",(V1+V2));
            //        break;
            //    case '-':
            //        Console.WriteLine("Result : {0}", (V1 - V2));
            //        break;
            //    case '/':
            //        Console.WriteLine("Result : {0}", (V1 / V2));
            //        break;
            //    case '*':
            //        Console.WriteLine("Result : {0}", (V1 * V2));
            //        break;
            //    default:
            //        Console.WriteLine("Opps! incorrect input or operator entered!");
            //        goto OperatorInput;
            //        //break;
            //}
        }
    }
}
