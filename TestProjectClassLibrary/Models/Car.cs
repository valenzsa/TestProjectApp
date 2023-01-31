using System;

namespace TestProject
{
    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car has started");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
