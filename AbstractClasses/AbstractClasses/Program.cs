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
            FourWheeler fourWheeler = new FourWheeler();
            Console.WriteLine(fourWheeler.Features());
            Console.ReadKey();

            // Vehicle vehicle = new Vehicle();  // compiler will through an error if we try to create and object of abstract class. 
        }
    }

    abstract class Vehicle
    {
        public abstract string Features();      // Abstract class can have abstract methods

        public virtual int MaxSpeed() {      // Abstract class also have non abstract methods
            return 200;
        }
    }

    class FourWheeler : Vehicle
    {
        public override string Features()
        {
            return "This vehicle is a four wheeled honda city car.";
        }
    }
}

