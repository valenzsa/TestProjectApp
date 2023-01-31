using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test Project App");

            Car car = new Car();
            car.Start();

            LawnMower lawnMower = new LawnMower();
            lawnMower.Stop();

            Console.ReadLine();
        }
    }

    interface IVehicle
    {
        void Start();
        void Stop();
    }

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
