using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new AudiCar();
            Console.WriteLine($"{myCar.GetCost():c}");
            Console.WriteLine(myCar.Brand());

            Console.WriteLine();
            Console.WriteLine();

            var a3Car = new A3Car(myCar);
            Console.WriteLine($"{a3Car.GetCost():c}");
            Console.WriteLine(a3Car.Brand());

            Console.WriteLine();
            Console.WriteLine();

            var a3Sline = new A3Sline(a3Car);
            Console.WriteLine($"{a3Sline.GetCost():c}");
            Console.WriteLine(a3Sline.Brand());

        }
    }
}
