using Tien.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tien.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TienController : AbpControllerBase
    {
        protected TienController()
        {
            LocalizationResource = typeof(TienResource);
        }
    }
}