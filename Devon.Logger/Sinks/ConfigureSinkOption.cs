using Microsoft.Extensions.Options;

namespace Devon.Logger;

public class ConfigureSinkOption : IConfigureOptions<SinkOption>
{
    public void Configure(SinkOption options)
    {
        //configure default values
    }
}

