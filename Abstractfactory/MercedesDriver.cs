using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    class MercedesDriver : ICarDriver
    {
        public void GetDesc()
        {
            Console.WriteLine("I Can Drive only Mercedes cars.");
        }
    }
}
