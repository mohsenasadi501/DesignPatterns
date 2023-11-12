namespace DesignPatterns.Iterator
{
    internal interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();
    }
}
