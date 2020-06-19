using Manufacture.Models.AbstractModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyCar
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder(Car car)
        {
            _car = car;
        }
        public override void BuildDoors()
        {
            _car["doors"] = _car.Doors.ToString();
        }

        public override void BuildEngine()
        {
            _car["engine"] = "Engine added";
        }

        public override void BuildFrame()
        {
            _car["frame"] = "Advanced frame";
        }

        public override void BuildWheels()
        {
            _car["wheels"] = "4 wheels";
        }
        public void Show()

        {

            Console.WriteLine("\n---------------------------");

            Console.WriteLine("Serial number: {0}", _car.CarSerialNumber);

            Console.WriteLine(" Frame : {0}", _car["frame"]);

            Console.WriteLine(" Engine : {0}", _car["engine"]);

            Console.WriteLine(" #Wheels: {0}", _car["wheels"]);

            Console.WriteLine(" #Doors : {0}", _car["doors"]);

            Console.WriteLine(" #Options : ");

            if (_car.Options.CarOptions.Count > 0)
            {
                foreach (var option in _car.Options.CarOptions)
                {
                    int num = 1;
                    Console.WriteLine($"{num}: {option}");
                    num++;
                }

            }

        }
    }
}
