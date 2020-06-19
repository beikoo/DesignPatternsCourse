using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture.Models.AbstractModels
{
    public abstract class BMWXCar : Car
    {
        public BMWXCar()
        {

        }
        public abstract void TractionOffroadControl();
        public abstract void SoundSystem(string name);

    }
}
