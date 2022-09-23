using treeApi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace treeApi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(treeApiEntityFrameworkCoreModule),
    typeof(treeApiApplicationContractsModule)
)]
public class treeApiDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });
    }
}
