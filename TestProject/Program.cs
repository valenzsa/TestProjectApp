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

            Boat boat = new Boat();
            boat.Start();

            Console.ReadLine();
        }
    }
}
