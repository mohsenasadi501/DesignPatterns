namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        protected override bool doHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}
