﻿using System;

namespace ISP.Vehicles
{
    class Car : IVehicleCar
    {
        private string color;

        private int year;

        private double engine;

        private int seats;

        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Criando um carro {color}, {year}, {engine}, {doors} portas e {seats} assentos.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores do carro...");
        }
    }
}