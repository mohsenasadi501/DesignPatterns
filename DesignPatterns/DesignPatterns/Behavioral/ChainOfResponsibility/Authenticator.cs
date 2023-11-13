namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    internal class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        protected override bool doHandle(HttpRequest request)
        {
            var isValid = request.UserName == "admin" && request.Password == "1234";

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
