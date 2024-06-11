using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ABP.MVCCore.EntityFrameworkCore
{
    public class MVCCoreDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MVCCoreDbContext(DbContextOptions<MVCCoreDbContext> options) 
            : base(options)
        {

        }
    }
}
