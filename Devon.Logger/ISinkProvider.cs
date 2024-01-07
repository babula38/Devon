namespace Devon.Logger;

public interface ISinkProvider
{
  ISink GetSink(MessageLevelType levelType);
}
