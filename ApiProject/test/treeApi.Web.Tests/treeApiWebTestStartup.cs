using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace treeApi;

public class treeApiWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<treeApiWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
