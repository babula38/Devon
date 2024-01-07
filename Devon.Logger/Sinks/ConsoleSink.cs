namespace Devon.Logger;

public sealed class ConsoleSink : ISink
{
    public void Process(SinkContext context)
    {
        Console.WriteLine($"Console:{context.Message}");
    }
}

