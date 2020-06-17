using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class AudiCar : ICar
    {
        public string Brand()
        {
            return "Audi";
        }

        public int GetCost()
        {
            return 5000;
        }
    }
}
