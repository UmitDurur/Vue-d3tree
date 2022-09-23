using treeApi.Localization;
using Volo.Abp.Application.Services;

namespace treeApi;

/* Inherit your application services from this class.
 */
public abstract class treeApiAppService : ApplicationService
{
    protected treeApiAppService()
    {
        LocalizationResource = typeof(treeApiResource);
    }
}
