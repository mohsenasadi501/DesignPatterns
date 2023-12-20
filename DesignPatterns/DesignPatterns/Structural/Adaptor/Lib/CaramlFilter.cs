namespace DesignPatterns.Structural.Adaptor.Lib
{
    /// <summary>
    /// Adapter
    /// </summary>
    internal class CaramlFilter : Caramel, IFilter
    {
        public void apply(Image image)
        {
            init();
            render(image);
        }
    }
}
