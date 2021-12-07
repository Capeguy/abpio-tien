using Tien.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Tien.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TienEntityFrameworkCoreModule),
        typeof(TienApplicationContractsModule)
        )]
    public class TienDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
