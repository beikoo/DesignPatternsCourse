using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture.Models
{
    public class BMW520Car : BMWSportCar
    {
        public BMW520Car()
        {
        }

        public override void MPower()
        {
            base.HorsePowers = 200;
        }
    }
}
