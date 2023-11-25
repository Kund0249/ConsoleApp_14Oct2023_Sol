using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS.Abstraction
{
   public abstract class Mobile
    {
        public string ModelNumber { get; set; }
        public string BrandName { get; set; }
        public string Price { get; set; }
        public string RAMSize { get; set; }

        //abtsract Method
        public abstract void VolumeUP();
        public abstract void VolumeDown();

        //Non Abstract Method
        public void ShutDwon()
        {
            //code
        }

    }
}
