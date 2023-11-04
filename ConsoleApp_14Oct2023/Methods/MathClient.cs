using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.Methods
{
    class MathClient
    {
        public bool IsPrime(int Value)
        {
            for (int i = 2; i < Value/2; i++)
            {
                if(Value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
