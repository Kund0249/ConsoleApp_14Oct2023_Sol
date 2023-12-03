using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ExceptionHandling
{
    class Statusp
    {
        static void Main(string[] args)
        {
            //console.Writeline(); //Compile Time Error/ Syntax Error

            //string s = "1djdk";
            //int n = Convert.ToInt32(s);//Run Time Error/ Logical Mistake

            //int a = 0;
            //int b = 10;
            //int c = b / a;//Run Time Error/ Logical Mistake

            //Employee employee = null;

            //if(employee != null)
            // Console.WriteLine("Id : {0} Name : {1}",employee.EmpCode,employee.Name);


            try
            {
                Console.WriteLine("Program Started");
                Console.Write("Enter N1 : ");
                int N1 = Convert.ToInt32(Console.ReadLine());
                if (N1 <= 0)
                    throw new Exception("Number should be a positive Integer");

                Console.Write("Enter N2 : ");
                int N2 = Convert.ToInt32(Console.ReadLine());
                if (N2 <= 0)
                    throw new Exception("Number should be a positive Integer");
                int Res = N1 / N2;

                Console.WriteLine("Result : " + Res);

            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                string folderPath = @"C:\Users\Admin\Desktop\Sample\ErrorLog";
                string FileName = "log.txt";
                //string fullpath = folderPath + "\\" + FileName;
                string fullpath = Path.Combine(folderPath, FileName);

                StreamWriter writer = new StreamWriter(fullpath,true);
                writer.WriteLine("---------------{0}----------", DateTime.Now);
                writer.WriteLine("Error Type : " + ex.GetType());
                writer.WriteLine("Error Message : " + ex.Message);
                writer.WriteLine("Stack Trace : " + ex.StackTrace);
                writer.WriteLine("------------------End----------------");
                writer.Close();
                //Exception Log
                Console.WriteLine("Error Message : " + ex.Message);
                Console.WriteLine("Currently system is not able to process your request. please try after some time!");
            }
            finally
            {
                Console.WriteLine("Program Completed");

            }
        }
    }
}
