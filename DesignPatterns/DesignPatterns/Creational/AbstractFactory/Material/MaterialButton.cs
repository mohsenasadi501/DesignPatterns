namespace DesignPatterns.Creational.AbstractFactory.Material
{
    internal class MaterialButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}
