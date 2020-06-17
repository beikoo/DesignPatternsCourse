using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    public class AudiDriver : ICarDriver
    {
        public void GetDesc()
        {
            Console.WriteLine("I can drive only Audi cars");
        }
    }
}
