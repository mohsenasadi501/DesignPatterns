namespace DesignPatterns.Behavioral.Iterator
{
    /// <summary>
    /// IIterator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();
    }
}