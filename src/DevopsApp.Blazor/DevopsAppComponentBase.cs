using DevopsApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DevopsApp.Blazor;

public abstract class DevopsAppComponentBase : AbpComponentBase
{
    protected DevopsAppComponentBase()
    {
        LocalizationResource = typeof(DevopsAppResource);
    }
}
