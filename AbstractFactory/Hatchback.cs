using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Hatchback:Car
    {
        public void assemble()
        {
            Console.WriteLine("Assembling Hatchback Car");
        }
    }
}
