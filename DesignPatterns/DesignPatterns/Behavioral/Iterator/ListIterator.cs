namespace DesignPatterns.Behavioral.Iterator
{
    /// <summary>
    /// IAggregate
    /// </summary>
    internal class ListIterator : IIterator<string>
    {
        private List<string> lst = new List<string>();
        int position = 0;

        public ListIterator(List<string> list)
        {
            lst = list;
        }

        public string Current()
        {
            return lst[position];
        }

        public bool HasNext()
        {
            if (position >= lst.Count)
                return false;
            else
                return true;
        }

        public void Next()
        {
            string transaction = lst[position];
            position += 1;
        }
    }
}
