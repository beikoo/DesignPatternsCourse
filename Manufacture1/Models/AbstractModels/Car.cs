using System;
using System.Collections.Generic;
using System.Text;

namespace Manufacture.Models.AbstractModels
{
    public abstract class Car
    {
        private int _doors = 4;
        public string CarSerialNumber { get; set; }

        private Dictionary<string, string> _parts =

        new Dictionary<string, string>();
        public int HorsePowers { get; set; }
        public Options Options { get; set; }

        public int Doors
        {
            get
            {
                return this._doors;
            }
            set
            {
                _doors = value;
            }
        }


        public Car()
        {
            CarSerialNumber = Guid.NewGuid().ToString();
            Options = new Options();
        }

        public virtual void DoorsType(int number = 4)
        {
            Doors = number;
        }

        public string this[string key]
        {

            get { return _parts[key]; }

            set { _parts[key] = value; }

        }
    }
}
