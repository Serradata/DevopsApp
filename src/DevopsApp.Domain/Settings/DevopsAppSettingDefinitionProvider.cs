using Volo.Abp.Settings;

namespace DevopsApp.Settings;

public class DevopsAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(DevopsAppSettings.MySetting1));
    }
}
