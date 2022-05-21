using DevopsApp.Localization;
using Volo.Abp.Application.Services;

namespace DevopsApp;

/* Inherit your application services from this class.
 */
public abstract class DevopsAppAppService : ApplicationService
{
    protected DevopsAppAppService()
    {
        LocalizationResource = typeof(DevopsAppResource);
    }
}
