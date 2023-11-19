namespace DesignPatterns.Creational.Factory
{
    internal class SharpController : Controller
    {
        public new IViewEngine CreateViewEngine()
        {
            return new SharpViewEngine();
        }
    }
}
