using Microsoft.Extensions.DependencyInjection;

namespace Devon.Logger;

public class SinkProvider : ISinkProvider
{
    private readonly IServiceProvider services;

    public SinkProvider(IServiceProvider services)
    {
        this.services = services;
    }
    public ISink GetSink(MessageLevelType levelType)
    {
        var syn = services.GetService<IEnumerable<ISink>>();
        var fileSync = syn.First(x => x.GetType() == typeof(FileSink));
        var consoleSync = syn.First(x => x.GetType() == typeof(ConsoleSink));

        return levelType switch
        {
            MessageLevelType.Fatal
                or MessageLevelType.Error
                or MessageLevelType.Warn => fileSync,
            MessageLevelType.Debug
                or MessageLevelType.Info => consoleSync,
        };
    }
}

