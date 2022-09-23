using treeApi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace treeApi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class treeApiController : AbpControllerBase
{
    protected treeApiController()
    {
        LocalizationResource = typeof(treeApiResource);
    }
}
