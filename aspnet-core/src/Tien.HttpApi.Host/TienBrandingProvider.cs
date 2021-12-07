using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Tien
{
    [Dependency(ReplaceServices = true)]
    public class TienBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Tien";
    }
}
