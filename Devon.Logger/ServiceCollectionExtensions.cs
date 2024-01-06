using Devon.Logger;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDevonLogger(
        this IServiceCollection serviceCollection
        , Action<SinkOption> config)
    {
        serviceCollection.Configure(config);
        serviceCollection.AddTransient<IConfigureOptions<SinkOption>, ConfigureSinkOption>();

        serviceCollection.AddSingleton<ISinkProvider, SinkProvider>();
        serviceCollection.AddSingleton<ISink, ConsoleSink>();
        serviceCollection.AddTransient(typeof(IDevonLogger<>), typeof(DevonLogger<>));

        return serviceCollection;
    }
}
