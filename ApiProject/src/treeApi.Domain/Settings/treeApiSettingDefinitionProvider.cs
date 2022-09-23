using Volo.Abp.Settings;

namespace treeApi.Settings;

public class treeApiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(treeApiSettings.MySetting1));
    }
}
