namespace DesignPatterns.Creational.AbstractFactory.Ant
{
    internal class AntTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}
