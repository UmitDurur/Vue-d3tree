using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace treeApi.Web;

[Dependency(ReplaceServices = true)]
public class treeApiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "treeApi";
}
