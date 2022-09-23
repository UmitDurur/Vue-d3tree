using System.Threading.Tasks;

namespace treeApi.Data;

public interface ItreeApiDbSchemaMigrator
{
    Task MigrateAsync();
}
