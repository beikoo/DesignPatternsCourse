using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture
{
    public abstract class AbstractFactory
    {
        public abstract BMWXCar CreateOffroadCar();
        public abstract BMWSportCar CreateSportCar();
    }
}
