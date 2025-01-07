using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern_HeadFirst
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public override abstract string getDescription();
    }


}
