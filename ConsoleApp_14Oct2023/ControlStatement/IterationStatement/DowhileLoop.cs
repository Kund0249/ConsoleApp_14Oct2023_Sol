using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ControlStatement.IterationStatement
{
    class DowhileLoop
    {
        static void Main(string[] args)
        {
            char ToContinue;
            do
            {
                Console.Write("Enter Value 1 : ");
                int V1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Value 2 : ");
                int V2 = int.Parse(Console.ReadLine());

                SelectOperator: //lable
                Console.Write("select => [+ , - , / , *] : ");
                char _operator = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (_operator)
                {
                    case '+':
                        Console.WriteLine("Result : {0}", (V1 + V2));
                        break;
                    case '-':
                        Console.WriteLine("Result : {0}", (V1 - V2));
                        break;
                    case '/':
                        Console.WriteLine("Result : {0}", (V1 / V2));
                        break;
                    case '*':
                        Console.WriteLine("Result : {0}", (V1 * V2));
                        break;
                    default:
                        Console.WriteLine("Opps! incorrect input or operator entered!");
                        goto SelectOperator;
                        //break;
                }

                Console.Write("Press Y to continue : ");
                ToContinue = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (ToContinue == 'y');
           

        }
    }
}
