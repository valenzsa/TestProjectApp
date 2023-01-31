using System;

namespace TestProject
{
    public class LawnMower : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Lawn Mower has started");
        }

        public void Stop()
        {
            Console.WriteLine("Lawn Mower has stopped");
        }
    }
}
