using System;
using System.Collections.Generic;
using System.Text;
using Tien.Localization;
using Volo.Abp.Application.Services;

namespace Tien
{
    /* Inherit your application services from this class.
     */
    public abstract class TienAppService : ApplicationService
    {
        protected TienAppService()
        {
            LocalizationResource = typeof(TienResource);
        }
    }
}
