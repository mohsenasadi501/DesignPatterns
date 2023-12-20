namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Prototype Interface
    /// </summary>
    public interface IComponent
    {
        void Render();
        IComponent CloneObject();
    }
}
