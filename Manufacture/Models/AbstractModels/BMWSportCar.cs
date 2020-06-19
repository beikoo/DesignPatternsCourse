using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture.Models.AbstractModels
{
    public abstract class BMWSportCar : Car
    {
        public BMWSportCar()
        {
        }
        public virtual void MPower()
        {
            this.HorsePowers += 100;
        }
    }
}
