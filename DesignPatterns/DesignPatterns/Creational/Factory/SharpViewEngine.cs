namespace DesignPatterns.Creational.Factory
{
    internal class SharpViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> parameters)
        {
            return "View Rendered by sharp";
        }
    }
}
