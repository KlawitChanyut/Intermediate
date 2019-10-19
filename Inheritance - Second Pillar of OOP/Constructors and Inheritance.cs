using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Inheritance_Second
{
    public class Constructors_and_Inheritance
    {
        public Constructors_and_Inheritance()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }

        public Constructors_and_Inheritance(string registrationNumber)
        {

        }
    }

    public class Car : Constructors_and_Inheritance
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
}
