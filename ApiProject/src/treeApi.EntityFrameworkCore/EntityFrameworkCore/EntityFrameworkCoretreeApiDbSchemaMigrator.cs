using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using treeApi.Data;
using Volo.Abp.DependencyInjection;

namespace treeApi.EntityFrameworkCore;

public class EntityFrameworkCoretreeApiDbSchemaMigrator
    : ItreeApiDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoretreeApiDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the treeApiDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<treeApiDbContext>()
            .Database
            .MigrateAsync();
    }
}
