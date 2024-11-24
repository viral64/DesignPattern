using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHeadFirst.Interface
{
    public class Quack:IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
    }
}
