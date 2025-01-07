using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_HeadFirst.ConcreteBeverage
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }
        public override double cost()
        {
            return 0.99;
        }
    }

}
