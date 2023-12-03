using System;
using System.IO;
using System.Text;


namespace ConsoleApp_14Oct2023.FileHandling
{
    class Startup
    {
        static void Main(string[] args)
        {

            string folderPath = @"C:\Users\Admin\Desktop\Sample\ErrorLog";
            string FileName = "log.txt";
            //string fullpath = folderPath + "\\" + FileName;
            string fullpath = Path.Combine(folderPath, FileName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(fullpath))
            {
                File.Create(fullpath);
            }

           
            StreamWriter writer = new StreamWriter(fullpath,true);

            writer.WriteLine("New text");
          
            writer.Close();

            Console.WriteLine("Program Completed!");

            //if (File.Exists(fullpath))
            //{
            //    Console.WriteLine("File is There");
            //    File.Delete(fullpath);
            //}
            //else
            //{
            //    File.Create(fullpath);
            //    Console.WriteLine("File Created");
            //}
        }
    }
}
