using StrategyPatternHeadFirst.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHeadFirst
{
    public class DuckModel:Duck
    {
        public DuckModel()
        {
            //Create instance in parent class
            FlyBehavior = new FlywithWings();
            QuackBehavior = new MuteQuack();
        }
        public override void Display()
        {
           Console.WriteLine("I'm a model duck");
        }
       
    }
}
