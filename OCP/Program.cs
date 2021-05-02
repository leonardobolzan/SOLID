using OCP.Vehicles;
using System;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MOTORCYCLE;

            if (type == TypeVehicle.CAR)
            {
                Car vehicle = new Car("Vermelho", 2022, 2.0, 5, 4);
                
            } else
            {
                Motorcycle vehicle = new Motorcycle("Branca", 2023, 300);

            }

            Console.ReadLine();
        }
    }
}
