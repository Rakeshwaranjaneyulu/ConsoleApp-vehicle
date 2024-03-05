using ConsoleApp_vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_vehicle
{
    internal class Car : Vehicle
    {
        
        public string Model { get; set; }
        public int NumberOfDoors { get; set; }

        // Correct the constructor to properly call the base constructor.
        public Car(string make, int year, string model, int numberOfDoors)
            : base(make, year) // This calls the Vehicle's constructor with 'make' and 'year'.
        {
            Model = model;
            NumberOfDoors = numberOfDoors;
        }

        public void Accelerate()
        {
            Console.WriteLine("Car is accelerating.");
        }

        public void Brake()
        {
            Console.WriteLine("Car is braking.");
        }
    }

}





