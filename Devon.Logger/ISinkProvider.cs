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
          MessageLevelType.Fatal
            or MessageLevelType.Error
            or MessageLevelType.Warn => new FileSink(),
          MessageLevelType.Debug
            or MessageLevelType.Info => new ConsoleSink(),
      };
}

