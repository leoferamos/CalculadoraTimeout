public class CircuitBreaker
{
    public CircuitBreakerState State { get; set; }

    public CircuitBreaker()
    {
     
        State = new ClosedState();
    }

    public void HandleRequest()
    {
        State.HandleRequest(this);
    }
}
