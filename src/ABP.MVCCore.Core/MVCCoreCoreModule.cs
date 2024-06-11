using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.MVCCore.Localization;

namespace ABP.MVCCore
{
    public class MVCCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MVCCoreLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MVCCoreConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MVCCoreCoreModule).GetAssembly());
        }
    }
}