namespace Strategy
{
    public class SortingContext
    {
        private SortingStrategy _strategy;
        public SortingContext(SortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void setSortingStrategy(SortingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void performSort(int[] array)
        {
            _strategy.sort(array);
        }

    }
}
