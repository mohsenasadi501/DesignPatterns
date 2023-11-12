namespace DesignPatterns.Iterator
{
    internal class BrowseHistory
    {
        private List<string> _history;
        public BrowseHistory()
        {
            _history = new List<string>();
        }
        public void AddHistory(string history)
        {
            _history.Add(history);
        }
        public IIterator<string> CreateIterator()
        {
            return new ListIterator(_history);
        }
    }
}
