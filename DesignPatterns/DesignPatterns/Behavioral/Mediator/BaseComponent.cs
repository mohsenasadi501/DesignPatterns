namespace DesignPatterns.Behavioral.Mediator
{
    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    public class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
