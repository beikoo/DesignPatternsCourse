using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    class Mercedes : ICar
    {
        public void Desc()
        {
            Console.WriteLine("Mercedes");
        }
    }
}
