namespace Devon.Logger;

public interface ISinkProvider
{
    ISink GetSink(MessageLevelType levelType);
}

public class SinkProvider : ISinkProvider
{
    public ISink GetSink(MessageLevelType levelType)
      => levelType switch
      {
          MessageLevelType.Fatal => default,
          MessageLevelType.Warn => default,
          MessageLevelType.Error => default,
          MessageLevelType.Info => default,
          MessageLevelType.Debug => default,
      };
}

