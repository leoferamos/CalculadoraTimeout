using System;

public class TimeoutGenerator
{
    private static TimeoutGenerator _instance;
    private Random _random;

    private TimeoutGenerator()
    {
        _random = new Random();
    }

    public static TimeoutGenerator GetInstance()
    {
        if (_instance == null)
        {
            _instance = new TimeoutGenerator();
        }
        return _instance;
    }

    public int GetRandomTimeout(int minValue, int maxValue)
    {
        return _random.Next(minValue, maxValue);
    }
}
