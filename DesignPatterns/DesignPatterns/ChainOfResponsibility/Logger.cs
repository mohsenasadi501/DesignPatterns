namespace DesignPatterns.ChainOfResponsibility
{
    internal class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        protected override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        }
    }
}
