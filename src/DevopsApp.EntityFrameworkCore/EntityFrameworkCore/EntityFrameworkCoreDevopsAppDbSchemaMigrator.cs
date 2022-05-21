using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DevopsApp.Data;
using Volo.Abp.DependencyInjection;

namespace DevopsApp.EntityFrameworkCore;

public class EntityFrameworkCoreDevopsAppDbSchemaMigrator
    : IDevopsAppDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreDevopsAppDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the DevopsAppDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<DevopsAppDbContext>()
            .Database
            .MigrateAsync();
    }
}
