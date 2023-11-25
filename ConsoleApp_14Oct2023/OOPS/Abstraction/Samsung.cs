using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_14Oct2023.OOPS.Abstraction
{
    class Samsung : Mobile
    {
        public string Series { get; set; }
        public void RightSwipCall()
        {

        }

        public void LeftSwipMessage()
        {

        }

        public override void VolumeUP()
        {
            throw new NotImplementedException();
        }

        public override void VolumeDown()
        {
            throw new NotImplementedException();
        }

        public void AssembleMobile(string Model,string cost)
        {
            ModelNumber = Model;
            Price = cost;
        }
    }
}
