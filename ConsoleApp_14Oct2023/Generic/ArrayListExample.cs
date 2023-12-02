using System;
using System.Collections.Generic;
using System.Collections; //not in use

namespace ConsoleApp_14Oct2023.Generic
{
    class ArrayListExample
    {
        static void Main(string[] args)
        {
            //Array has fixed in size
            int[] Aray = new int[2];
            //Aray[0] = "10";

            //ArrayList is flexiable in size but not type safe
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(1);
            //list.Add("10");

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
