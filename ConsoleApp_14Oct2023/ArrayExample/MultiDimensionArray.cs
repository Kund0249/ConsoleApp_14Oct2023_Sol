using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.ArrayExample
{
    class MultiDimensionArray
    {
        static void Main(string[] args)
        {
            //int[] Array = new int[5];

            int[,] Array = new int[2, 3]
            {
              {10,20,1 },
              {30,40,2 }
            };

            int[,] Array2 = new int[2, 3]
              {
                  {10,20,1 },
                  {30,40,2 }
              };

            int[,] ResultArray = new int[2, 3];


            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    ResultArray[row, col] = Array[row, col] + Array2[row, col];
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(ResultArray[row,col] + "\t");
                    
                }
                Console.WriteLine();
            }

           

        }
    }
}
