using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.MVCCore.Configuration;
using ABP.MVCCore.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace ABP.MVCCore.Web.Startup
{
    [DependsOn(
        typeof(MVCCoreApplicationModule), 
        typeof(MVCCoreEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MVCCoreWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MVCCoreWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MVCCoreConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MVCCoreNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MVCCoreApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MVCCoreWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MVCCoreWebModule).Assembly);
        }
    }
}
