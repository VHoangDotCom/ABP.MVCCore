using System;
using System.Threading.Tasks;
using Abp.TestBase;
using ABP.MVCCore.EntityFrameworkCore;
using ABP.MVCCore.Tests.TestDatas;

namespace ABP.MVCCore.Tests
{
    public class MVCCoreTestBase : AbpIntegratedTestBase<MVCCoreTestModule>
    {
        public MVCCoreTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MVCCoreDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MVCCoreDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MVCCoreDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MVCCoreDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MVCCoreDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MVCCoreDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MVCCoreDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MVCCoreDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
