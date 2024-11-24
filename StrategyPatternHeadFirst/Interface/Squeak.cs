using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHeadFirst.Interface
{
    public class Squeak:IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
