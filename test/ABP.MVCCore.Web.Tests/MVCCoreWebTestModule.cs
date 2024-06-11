using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.MVCCore.Web.Startup;
namespace ABP.MVCCore.Web.Tests
{
    [DependsOn(
        typeof(MVCCoreWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MVCCoreWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MVCCoreWebTestModule).GetAssembly());
        }
    }
}