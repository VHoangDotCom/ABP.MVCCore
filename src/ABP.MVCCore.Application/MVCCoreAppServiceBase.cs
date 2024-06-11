using Abp.Application.Services;

namespace ABP.MVCCore
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MVCCoreAppServiceBase : ApplicationService
    {
        protected MVCCoreAppServiceBase()
        {
            LocalizationSourceName = MVCCoreConsts.LocalizationSourceName;
        }
    }
}