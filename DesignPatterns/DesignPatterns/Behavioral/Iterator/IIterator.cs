namespace DesignPatterns.Behavioral.Iterator
{
    internal interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();
    }
}