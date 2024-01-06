namespace Devon.Logger;

public interface IDevonLogger<TType>
{
    void Log(string message, MessageLevelType levelType);

    void LogFatal(string message);
    void LogError(string message);
    void LogWarning(string message);
    void LogInfo(string message);
    void LogDebug(string message);
}

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

        var formatedMessage = $"{DateTime.Now}-{typeof(TType).Namespace}:{message}";

        sink.Process(new SinkContext
        {
            Message = formatedMessage,
            NameSpaceName = typeof(TType).Namespace,
        });
    }

    public void LogDebug(string message) => Log(message, MessageLevelType.Debug);

    public void LogError(string message) => Log(message, MessageLevelType.Error);

    public void LogFatal(string message) => Log(message, MessageLevelType.Fatal);

    public void LogInfo(string message) => Log(message, MessageLevelType.Info);

    public void LogWarning(string message) => Log(message, MessageLevelType.Warn);
}
