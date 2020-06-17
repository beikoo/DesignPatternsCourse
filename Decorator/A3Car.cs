using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class A3Car:ICar
    {
        private readonly ICar aCar;
        public A3Car(ICar car)
        {
            aCar = car;
        }

        public string Brand()
        {
            return String.Concat(aCar.Brand(), " A3");
        }

        public int GetCost()
        {
            return aCar.GetCost() + 5000;
        }
    }
}
