public interface CircuitBreakerState
{
    void HandleRequest(CircuitBreaker circuitBreaker);
}

public class ClosedState : CircuitBreakerState
{
    public void HandleRequest(CircuitBreaker circuitBreaker)
    {
        
    }
}

public class OpenState : CircuitBreakerState
{
    public void HandleRequest(CircuitBreaker circuitBreaker)
    {
        
    }
}

public class HalfOpenState : CircuitBreakerState
{
    public void HandleRequest(CircuitBreaker circuitBreaker)
    {
        
    }
}
