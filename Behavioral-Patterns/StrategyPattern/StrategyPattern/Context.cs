namespace StrategyPattern
{
    public class Context
    {
        private ISort _sorter;

        public Context(ISort sorter)
        {
            this._sorter = sorter;
        }

        public void SetSorter(ISort sorter)
        {
            this._sorter = sorter;
        }

        public void Sort(int[] input)
        {
            _sorter.Sort(input);
        }
    }
}