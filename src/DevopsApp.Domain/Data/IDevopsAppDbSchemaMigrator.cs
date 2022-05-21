using System.Threading.Tasks;

namespace DevopsApp.Data;

public interface IDevopsAppDbSchemaMigrator
{
    Task MigrateAsync();
}
