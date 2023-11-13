namespace DesignPatterns.Structural.Adaptor
{
    internal class VividFilter : IFilter
    {
        public void apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter");
        }
    }
}
