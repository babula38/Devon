namespace Devon.Logger;

public class DevonLogger<TType> : IDevonLogger<TType>
{
    private readonly ISinkProvider _sinkProvider;

    public DevonLogger(ISinkProvider sinkProvider)
    {
        _sinkProvider = sinkProvider;
    }

    public void Log(string message, MessageLevelType levelType)
    {
        ISink sink = _sinkProvider.GetSink(levelType);

        var formattedMessage = $"{DateTime.Now}-{typeof(TType).Namespace}:{message}";

        sink.Process(new SinkContext
        {
            Message = formattedMessage,
        });
    }

    public void LogDebug(string message) => Log(message, MessageLevelType.Debug);

    public void LogError(string message) => Log(message, MessageLevelType.Error);

    public void LogFatal(string message) => Log(message, MessageLevelType.Fatal);

    public void LogInfo(string message) => Log(message, MessageLevelType.Info);

    public void LogWarning(string message) => Log(message, MessageLevelType.Warn);
}
