using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EuropeSpecification:CarSpecification
    {
        public void display()
        {
            Console.WriteLine("Europe Car specification: Fuel efficency and emissions compliant with EU standards.");
        }
    }
}
