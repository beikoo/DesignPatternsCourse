using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractfactory
{
    interface ICarFactory
    {
        ICar MakeCar();
        ICarDriver MakeCarDriver();
    }
}
