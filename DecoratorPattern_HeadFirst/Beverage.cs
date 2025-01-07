namespace DecoratorPattern_HeadFirst
{
    public abstract class Beverage
    {
        protected string description = "Unknown Beverage";

        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }


}
