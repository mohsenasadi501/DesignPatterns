namespace DesignPatterns.Creational.Prototype
{
    internal class ContextMenu
    {
        void Duplicate(Component component)
        {
           Component newcomp =  component.Clone();
        }
    }
}
