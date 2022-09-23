using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace treeApi.Data;

/* This is used if database provider does't define
 * ItreeApiDbSchemaMigrator implementation.
 */
public class NulltreeApiDbSchemaMigrator : ItreeApiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
