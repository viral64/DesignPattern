using StrategyPatternHeadFirst.Interface;

namespace StrategyPatternHeadFirst
{
    public abstract class Duck
    {
        protected IFlyBehaviour FlyBehavior;
        protected IQuackBehaviour QuackBehavior;

        public Duck() { }

        //Display method is abstract since all subtypes looks different
        public abstract void Display();

        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        //set dynamically behaviour at run time
        public void SetFlyBehavior(IFlyBehaviour fb)
        {
            FlyBehavior = fb;
        }

        //set dynamically behaviour at run time
        public void SetQuackBehavior(IQuackBehaviour qb)
        {
            QuackBehavior = qb;
        }
    }
}
