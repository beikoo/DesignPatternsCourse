using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class IronDoor : IDoor
    {
        public void GetDesc()
        {
            Console.WriteLine("IronDoor");
        }
    }
}
