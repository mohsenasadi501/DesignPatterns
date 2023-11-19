namespace DesignPatterns.Creational.Factory
{
    internal class Controller
    {
        public void Render(string viewName, Dictionary<string, object> context)
        {
            var engine = CreateViewEngine();
            var html = engine.Render(viewName, context);
            Console.WriteLine(html);
        }

        protected IViewEngine CreateViewEngine()
        {
            return new MatchaViewEngine();
        }
    }
}
