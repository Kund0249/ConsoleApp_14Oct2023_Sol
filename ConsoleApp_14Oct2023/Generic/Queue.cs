using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Generic
{
    class Queue
    {
        static void Main(string[] args)
        {
            //FIFO - (Firt In First Out)
            Queue<int> TokenQueue = new Queue<int>();
            TokenQueue.Enqueue(1);
            TokenQueue.Enqueue(2);
            TokenQueue.Enqueue(3);
            TokenQueue.Enqueue(4);

            //TokenQueue.Dequeue();//1

            int token = TokenQueue.Peek();
            Console.WriteLine("Ready for Service : " + token);
            TokenQueue.Dequeue();//1

            //TokenQueue.Dequeue();//2

            foreach (int item in TokenQueue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
