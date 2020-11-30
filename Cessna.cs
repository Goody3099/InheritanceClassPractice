using System;

namespace InheritanceClassPractice
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Zoom!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Cessna banks to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna glides to a stop");
        }
    }
}