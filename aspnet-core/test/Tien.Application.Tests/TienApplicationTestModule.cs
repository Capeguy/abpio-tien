using Volo.Abp.Modularity;

namespace Tien
{
    [DependsOn(
        typeof(TienApplicationModule),
        typeof(TienDomainTestModule)
        )]
    public class TienApplicationTestModule : AbpModule
    {

    }
}