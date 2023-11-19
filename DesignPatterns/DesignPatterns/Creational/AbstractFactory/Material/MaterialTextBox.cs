namespace DesignPatterns.Creational.AbstractFactory.Material
{
    internal class MaterialTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Material TextBox");
        }
    }
}
