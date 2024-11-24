using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NorthAmericaCarFactory : CarFactory
    {
        public Car createCar()
        {
            return new Sedan();
        }
        public CarSpecification createSpecification()
        {
            return new NorthAmericaSpecification();
        }
    }
}
