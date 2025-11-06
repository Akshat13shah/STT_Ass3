using System;

namespace part2_lab10
{
    // Base class
    class Vehicle
    {
        protected int speed;
        protected int fuel;

        public Vehicle(int speed, int fuel)
        {
            this.speed = speed;
            this.fuel = fuel;
        }

        public virtual void Drive()
        {
            fuel -= 5;
            Console.WriteLine("Vehicle is moving...");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed} km/h | Fuel: {fuel}");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        private int passengers;

        public Car(int speed, int fuel, int passengers)
            : base(speed, fuel)
        {
            this.passengers = passengers;
        }

        public override void Drive()
        {
            fuel -= 10;
            Console.WriteLine($"Car is moving with {passengers} passengers...");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed} km/h | Fuel: {fuel} | Passengers: {passengers}");
        }
    }

    // Derived class Truck
    class Truck : Vehicle
    {
        private int cargoWeight;

        public Truck(int speed, int fuel, int cargoWeight)
            : base(speed, fuel)
        {
            this.cargoWeight = cargoWeight;
        }

        public override void Drive()
        {
            fuel -= 15;
            Console.WriteLine($"Truck is moving with {cargoWeight} kg cargo...");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Speed: {speed} km/h | Fuel: {fuel} | Cargo: {cargoWeight} kg");
        }
    }

    // Main program
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[]
            {
                new Vehicle(60, 100),
                new Car(80, 100, 4),
                new Truck(50, 100, 500)
            };

            foreach (Vehicle v in vehicles)
            {
                v.Drive();
                v.ShowInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Demonstrated runtime polymorphism with base-class array.");
        }
    }
}
