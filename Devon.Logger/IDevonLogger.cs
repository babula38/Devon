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
