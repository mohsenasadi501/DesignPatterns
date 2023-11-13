namespace DesignPatterns.ChainOfResponsibility
{
    internal abstract class Handler
    {
        private Handler _next;
        public Handler(Handler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (doHandle(request))
                return;
            if (_next != null)
                _next.Handle(request);
        }
        protected abstract bool doHandle(HttpRequest request);
    }
}
