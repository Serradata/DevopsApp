using DevopsApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace DevopsApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DevopsAppEntityFrameworkCoreModule),
    typeof(DevopsAppApplicationContractsModule)
)]
public class DevopsAppDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options =>
        {
            options.IsJobExecutionEnabled = false;
        });
    }
}
