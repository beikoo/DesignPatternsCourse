using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyCar
{
    public abstract class VehicleBuilder
    {
        protected Car _car;
        public Car Car { get; }
        public abstract void BuildFrame();

        public abstract void BuildEngine();

        public abstract void BuildWheels();

        public abstract void BuildDoors();
    }
}
