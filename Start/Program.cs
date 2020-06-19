using AssemblyCar;
using Manufacture.Models;
using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder carBuilder = new CarBuilder(new BMW520Car());
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildDoors();
            carBuilder.BuildWheels();
            carBuilder.Show();
        }
    }
}
