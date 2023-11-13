namespace DesignPatterns.Behavioral.Observer
{
    internal class DataSource : Subject
    {
        private int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                NotifyObserver();
            }
        }
    }
}
