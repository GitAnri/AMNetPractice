using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPractice
{
    public class Car : Vehicle
    {
        public override void startEngine()
        {
            Console.WriteLine("Car engine started");
        }
    }
}
