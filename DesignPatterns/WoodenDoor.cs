using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class WoodenDoor:IDoor
    {
        public void GetDesc()
        {
            Console.WriteLine("Wooden Door");
        }
    }
}
