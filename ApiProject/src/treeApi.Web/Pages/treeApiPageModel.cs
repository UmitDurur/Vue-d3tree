using treeApi.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace treeApi.Web.Pages;

public abstract class treeApiPageModel : AbpPageModel
{
    protected treeApiPageModel()
    {
        LocalizationResourceType = typeof(treeApiResource);
    }
}
