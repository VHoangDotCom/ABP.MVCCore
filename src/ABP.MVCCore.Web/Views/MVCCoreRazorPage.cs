using Abp.AspNetCore.Mvc.Views;

namespace ABP.MVCCore.Web.Views
{
    public abstract class MVCCoreRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MVCCoreRazorPage()
        {
            LocalizationSourceName = MVCCoreConsts.LocalizationSourceName;
        }
    }
}
