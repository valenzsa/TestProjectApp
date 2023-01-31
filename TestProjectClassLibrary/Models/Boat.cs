using System;

namespace TestProject
{
    public class Boat : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Boat has started");
        }
        public void Stop()
        {
            Console.WriteLine("Boat has stopped");
        }
    }
}
