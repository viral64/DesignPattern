using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHeadFirst.Interface
{
    public class FlywithWings:IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!!");
        }
    }
}
