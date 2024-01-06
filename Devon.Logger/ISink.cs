using Microsoft.Extensions.Options;

namespace Devon.Logger;

public interface ISink
{
    void Process(SinkContext context);
}

public class ConsoleSink : ISink
{
    public void Process(SinkContext context)
    {
        throw new NotImplementedException();
    }
}

public class SinkOption
{
  public string FilePath{get;set;}
  public string DbConnectionString{get;set;}
}

public class ConfigureSinkOption : IConfigureOptions<SinkOption>
{
    public void Configure(SinkOption options)
    {
      //configure default values
    }
}

