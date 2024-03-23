using Serilog;

namespace RDP.EDB.Management.WebApi.Extensions;

public static class SerilogExtensions
{
    public static ConfigureHostBuilder UseSerilog(this ConfigureHostBuilder hostBuilder)
    {
        hostBuilder.UseSerilog((context, configuration) =>
        {
            configuration.ReadFrom.Configuration(context.Configuration);
        });

        return hostBuilder;
    }
}
