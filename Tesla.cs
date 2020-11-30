using System;

namespace InheritanceClassPractice
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Telsa goes Vroommmm!!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Tesla drifts to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Tesla slows to a stop");
        }
    }
}