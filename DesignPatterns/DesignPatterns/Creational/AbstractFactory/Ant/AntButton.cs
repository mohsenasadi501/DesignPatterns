namespace DesignPatterns.Creational.AbstractFactory.Ant
{
    internal class AntButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Ant Button");
        }
    }
}
