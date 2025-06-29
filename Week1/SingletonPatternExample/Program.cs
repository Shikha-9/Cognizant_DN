using System;

public class Logger
{
    private static Logger _instance;
    private static readonly object _lock = new object();

    private Logger() {}

    public static Logger Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new Logger();
                return _instance;
            }
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

class Program
{
    static void Main()
    {
        var logger1 = Logger.Instance;
        var logger2 = Logger.Instance;

        logger1.Log("First message");
        logger2.Log("Second message");

        Console.WriteLine(object.ReferenceEquals(logger1, logger2));  // True
    }
}
