using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Co_Mechanic : IEmployee
    {
        private float aSalary;
        private string aName;
        public Co_Mechanic(float salary,string name)
        {
            this.aSalary = salary;
            this.aName = name;
        }
        public string Name()
        {
            return this.aName;
        }

        public string Role()
        {
            return "Co-Mechanic";
        }

        public float Salary()
        {
            return this.aSalary;
        }
    }
}
