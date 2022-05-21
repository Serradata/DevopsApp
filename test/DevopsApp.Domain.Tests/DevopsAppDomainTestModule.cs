using DevopsApp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DevopsApp;

[DependsOn(
    typeof(DevopsAppEntityFrameworkCoreTestModule)
    )]
public class DevopsAppDomainTestModule : AbpModule
{

}
