using System;
using System.Collections.Generic;



namespace ConsoleApp_14Oct2023.Generic
{
    class ListDemo
    {
        static void Main(string[] args)
        {
            //Allow the duplicate element in the collections
            List<int> NumberList = new List<int>();
            NumberList.Add(1);
            NumberList.Add(2);
            NumberList.Add(3);
            NumberList.Add(4);
            NumberList.Add(1);
            NumberList.Add(2);
            NumberList.Add(3);
            NumberList.Add(4);

            //var data = (from n in NumberList where n > 1 select n).ToList();

            //NumberList.RemoveAll(x => x == 4);

            foreach (int item in NumberList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
