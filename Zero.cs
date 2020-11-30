using System;

namespace InheritanceClassPractice
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes yyyeeeeeeooooooowwwww!!!!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The Zero carves to the {direction}");
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero sharply comes to a stop");
        }
    }
}