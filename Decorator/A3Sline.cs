using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class A3Sline : ICar
    {
        private readonly ICar aCar;
        public A3Sline(ICar car)
        {
            aCar = car;
        }
        public string Brand()
        {
            return String.Concat(aCar.Brand(), " SLine");
        }

        public int GetCost()
        {
            return aCar.GetCost() + 5000;
        }
    }
}
