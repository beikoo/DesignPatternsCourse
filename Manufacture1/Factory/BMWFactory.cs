using Manufacture.Models;
using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture
{
    public class BMWFactory : AbstractFactory
    {

        public override BMWXCar CreateOffroadCar()
        {
            return new BMWX1Car();
        }

        public override BMWSportCar CreateSportCar()
        {

            return new BMW520Car();
        }
    }
}
