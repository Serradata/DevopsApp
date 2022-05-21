using DevopsApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DevopsApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class DevopsAppController : AbpControllerBase
{
    protected DevopsAppController()
    {
        LocalizationResource = typeof(DevopsAppResource);
    }
}
