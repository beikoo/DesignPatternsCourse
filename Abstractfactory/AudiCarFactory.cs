using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    class AudiCarFactory : ICarFactory
    {
        public ICar MakeCar()
        {
            return new Audi();
        }

        public ICarDriver MakeCarDriver()
        {
            return new AudiDriver();
        }
    }
}
