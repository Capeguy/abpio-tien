using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tien.Data
{
    /* This is used if database provider does't define
     * ITienDbSchemaMigrator implementation.
     */
    public class NullTienDbSchemaMigrator : ITienDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}