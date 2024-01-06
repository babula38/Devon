namespace Devon.Logger;

public interface ISinkProvider
{
    ISink GetSink(MessageLevelType levelType);
}

public class SinkProvider : ISinkProvider
{
    public SinkProvider()
    {

    }

    public ISink GetSink(MessageLevelType levelType)
      => levelType switch
      {
          MessageLevelType.Fatal => default,
          MessageLevelType.Warn => default,
          MessageLevelType.Error => default,
          MessageLevelType.Info => new ConsoleSink(),
          MessageLevelType.Debug => default,
      };
}

