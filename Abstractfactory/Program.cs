using System;

namespace Abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var AudiCarFactory = new AudiCarFactory();
            var AudiCar = AudiCarFactory.MakeCar();
            var AudiDriver = AudiCarFactory.MakeCarDriver();

            AudiCar.Desc();
            AudiDriver.GetDesc();

            Console.WriteLine();
            Console.WriteLine();

            var MercedesCarFactory = new MercedesCarFactory();
            var MercedesCar = MercedesCarFactory.MakeCar();
            var MercedesDriver = MercedesCarFactory.MakeCarDriver();

            MercedesCar.Desc();
            MercedesDriver.GetDesc();
            Console.ReadKey();
        }
    }
}
