using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class AutoService
    {
        protected List<IEmployee> employees;

        public AutoService()
        {
            employees = new List<IEmployee>();
        }

        public void AddEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;

            foreach (var e in employees)
            {
                netSalary += e.Salary();
            }
            return netSalary;
        }
    }
}
