using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Mechanic : IEmployee
    {
        private string aName;
        private float aSalary;
        public Mechanic(float salary,string name)
        {
            this.aName = name;
            this.aSalary = salary;
        }
        public string Name()
        {
            return this.aName;
        }

        public string Role()
        {
            return "Mechanic";
        }

        public float Salary()
        {
            return this.aSalary;
        }
    }
}
