using System;
using System.Collections.Generic;


namespace ConsoleApp_14Oct2023.Generic
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> keyValuePairs = new Dictionary<int, Employee>();
            keyValuePairs.Add(1, new Employee() { Id = 1, Name = "A" });
            keyValuePairs.Add(2, new Employee() { Id = 2, Name = "A" });
            keyValuePairs.Add(3, new Employee() { Id = 3, Name = "A" });
            keyValuePairs.Add(4, new Employee() { Id = 4, Name = "A" });
            keyValuePairs.Add(5, new Employee() { Id = 5, Name = "A" });


            //var data = keyValuePairs[1];
            //Console.WriteLine("Id : {0} Name : {1}",data.Id,data.Name);

            //foreach (KeyValuePair<int,Employee> item in keyValuePairs)
            //{
            //    Console.WriteLine("Key : {0} - [Id : {1} Name : {2}]",item.Key,item.Value.Id,item.Value.Name);
            //}

        }


    }
}
