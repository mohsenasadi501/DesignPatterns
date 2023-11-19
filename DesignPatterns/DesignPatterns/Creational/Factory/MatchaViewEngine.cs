namespace DesignPatterns.Creational.Factory
{
    internal class MatchaViewEngine : IViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> parameters)
        {
            return "View Rendered by Matcha";
        }
    }
}
