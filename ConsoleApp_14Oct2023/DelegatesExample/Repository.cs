using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.DelegatesExample
{
   public class Repository
    {
        public void GetData(MyLogic logicdel)
        {
            List<int> list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15
            };
            
            foreach (int item in list)
            {
                if(logicdel.Invoke(item))
                  Console.WriteLine(item);
            }
        }
    }
}
