using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace DevopsApp.Data;

/* This is used if database provider does't define
 * IDevopsAppDbSchemaMigrator implementation.
 */
public class NullDevopsAppDbSchemaMigrator : IDevopsAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
