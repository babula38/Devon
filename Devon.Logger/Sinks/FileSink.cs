using Microsoft.Extensions.Options;

namespace Devon.Logger;

public sealed class FileSink : ISink
{
    private readonly IOptions<SinkOption> options;

    public FileSink(IOptions<SinkOption> options)
    {
        this.options = options;
    }
    public void Process(SinkContext context)
    {
        var filePath = options.Value.FilePath;

        Console.WriteLine($"File:{context.Message}");
    }
}

