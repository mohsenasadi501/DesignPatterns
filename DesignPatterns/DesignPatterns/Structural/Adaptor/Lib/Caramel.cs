namespace DesignPatterns.Structural.Adaptor.Lib
{
    /// <summary>
    /// Adaptee
    /// </summary>
    internal class Caramel
    {
        public void init()
        {
        }
        public void render(Image image)
        {
            Console.WriteLine("Applying Caramel Filter");
        }
    }
}
