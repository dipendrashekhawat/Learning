using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Console.WriteLine(vehicle.Features());
            Console.ReadKey();

            //FourWheeler fourWheeler = new FourWheeler(); compiler will through an error if we try to create and object of abstract class. 
        }
    }

    abstract class FourWheeler
    {
        public virtual string Features()
        {
            return "It's a four wheeled vehicle with pretty nice balance and speed.";
        }
    }

    class Vehicle : FourWheeler
    {
        public override string Features()
        {
            return "This vehicle is a four wheeled honda city car.";
        }
    }
}

