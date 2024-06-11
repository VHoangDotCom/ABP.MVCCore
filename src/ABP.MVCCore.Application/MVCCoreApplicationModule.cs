using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ABP.MVCCore
{
    [DependsOn(
        typeof(MVCCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MVCCoreApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MVCCoreApplicationModule).GetAssembly());
        }
    }
}