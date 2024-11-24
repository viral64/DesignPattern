using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EuropeCarFactory:CarFactory
    {
        public Car createCar()
        {
            return new Hatchback();
        }
        public CarSpecification createSpecification()
        {
            return new EuropeSpecification();
        }
    }
}
