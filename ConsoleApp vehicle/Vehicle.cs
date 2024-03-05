using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_vehicle
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }

        public Vehicle(string make, int year)
        {
            Make = make;
            Year = year;
        }

        public void Start()
        {
            Console.WriteLine("Vehicle engine started.");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle engine stopped.");
        }
    }
}





