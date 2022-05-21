using Volo.Abp.Modularity;

namespace DevopsApp;

[DependsOn(
    typeof(DevopsAppApplicationModule),
    typeof(DevopsAppDomainTestModule)
    )]
public class DevopsAppApplicationTestModule : AbpModule
{

}
