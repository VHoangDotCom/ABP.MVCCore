using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABP.MVCCore.EntityFrameworkCore
{
    [DependsOn(
        typeof(MVCCoreCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MVCCoreEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MVCCoreEntityFrameworkCoreModule).GetAssembly());
        }
    }
}