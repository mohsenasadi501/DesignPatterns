namespace DesignPatterns.Structural.Adaptor.Lib
{
    internal class CaramlFilter : Caramel, IFilter
    {
        public void apply(Image image)
        {
            init();
            render(image);
        }
    }
}
