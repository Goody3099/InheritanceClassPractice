using System;

namespace InheritanceClassPractice
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"the vehicle carefully turns {direction}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine("the vehicle carefully comes to a stop.");
        }
    }
}