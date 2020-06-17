using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    class Audi : ICar
    {
        public void Desc()
        {
            Console.WriteLine("Audi");
        }
    }
}
