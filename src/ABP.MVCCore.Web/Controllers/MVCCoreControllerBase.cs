using Abp.AspNetCore.Mvc.Controllers;

namespace ABP.MVCCore.Web.Controllers
{
    public abstract class MVCCoreControllerBase: AbpController
    {
        protected MVCCoreControllerBase()
        {
            LocalizationSourceName = MVCCoreConsts.LocalizationSourceName;
        }
    }
}