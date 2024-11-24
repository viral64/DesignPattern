using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHeadFirst.Interface
{
    //Seprate the behaviour which varies frequently
    public interface IQuackBehaviour
    {
        public void quack();
    }
}
