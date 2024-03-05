using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the Car class.
            Car myCar = new Car("Toyota", 2020, "Camry", 4);

            // Using methods from the Vehicle base class.
            myCar.Start();
            myCar.Stop();

            // Using methods defined in the Car class.
            myCar.Accelerate();
            myCar.Brake();
        }
    }
}





