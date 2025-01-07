using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_HeadFirst.ConcreteCondiment
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        public override double cost()
        {
            return beverage.cost() + 0.10;
        }
    }

}
