using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    class MercedesCarFactory : ICarFactory
    {
        public ICar MakeCar()
        {
            return new Mercedes();
        }

        public ICarDriver MakeCarDriver()
        {
            return new MercedesDriver();
        }
    }
}
