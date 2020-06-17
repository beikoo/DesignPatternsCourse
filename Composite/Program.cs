using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic(5000,"Zdravko");
            var CoMechanic = new Co_Mechanic(3500,"Petur");
            Console.WriteLine($"The salary of {mechanic.Name()} is {mechanic.Salary():c}");
            Console.WriteLine($"The salary of {CoMechanic.Name()} is {CoMechanic.Salary():c}");

            var autoservice = new AutoService();
            autoservice.AddEmployee(mechanic);
            autoservice.AddEmployee(CoMechanic);
            Console.WriteLine($"net salary of all employees in this Autoservice is {autoservice.GetNetSalaries():c}");
        }
    }
}
