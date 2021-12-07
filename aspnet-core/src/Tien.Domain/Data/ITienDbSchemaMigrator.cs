using System.Threading.Tasks;

namespace Tien.Data
{
    public interface ITienDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
