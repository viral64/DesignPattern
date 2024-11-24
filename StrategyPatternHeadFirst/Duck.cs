using StrategyPatternHeadFirst.Interface;

namespace StrategyPatternHeadFirst
{
    public abstract class Duck
    {
        protected IFlyBehaviour FlyBehavior;
        protected IQuackBehaviour QuackBehavior;

        public Duck() { }

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

        public void SetFlyBehavior(IFlyBehaviour fb)
        {
            FlyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehaviour qb)
        {
            QuackBehavior = qb;
        }
    }
}
