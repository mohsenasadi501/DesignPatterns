namespace DesignPatterns.Creational.Prototype
{
    public interface Component
    {
        void Render();
        Component Clone();
    }
}
