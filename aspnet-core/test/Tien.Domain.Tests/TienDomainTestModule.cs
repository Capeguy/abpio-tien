using Tien.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Tien
{
    [DependsOn(
        typeof(TienEntityFrameworkCoreTestModule)
        )]
    public class TienDomainTestModule : AbpModule
    {

    }
}