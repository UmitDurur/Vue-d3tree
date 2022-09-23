using Volo.Abp.Modularity;

namespace treeApi;

[DependsOn(
    typeof(treeApiApplicationModule),
    typeof(treeApiDomainTestModule)
    )]
public class treeApiApplicationTestModule : AbpModule
{

}
