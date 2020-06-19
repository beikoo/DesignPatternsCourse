using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture.Models
{
    public class BMWX1Car : BMWXCar
    {
        public BMWX1Car()
        {
        }

        public override void SoundSystem(string name)
        {
            base.Options.CarOptions.Add(name);
        }

        public override void TractionOffroadControl()
        {
            base.Options.CarOptions.Add("Traction Trail 4x4");
        }
    }
}
