using ISP.Vehicles;
using System;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2022, 3.0, 5, 5);
            Motorcycle motorcycle = new Motorcycle("Branca", 2021, 600);

            Console.ReadLine();
        }
    }
}
