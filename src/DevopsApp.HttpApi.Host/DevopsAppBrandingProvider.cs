using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DevopsApp;

[Dependency(ReplaceServices = true)]
public class DevopsAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DevopsApp";
}
