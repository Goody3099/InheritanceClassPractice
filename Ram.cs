using System;

namespace InheritanceClassPractice
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram goes Rrrummbbbblllee!!!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Ram turns to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Ram slides to a stop");
        }
    }
}