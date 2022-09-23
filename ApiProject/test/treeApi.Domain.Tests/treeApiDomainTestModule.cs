using treeApi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace treeApi;

[DependsOn(
    typeof(treeApiEntityFrameworkCoreTestModule)
    )]
public class treeApiDomainTestModule : AbpModule
{

}
