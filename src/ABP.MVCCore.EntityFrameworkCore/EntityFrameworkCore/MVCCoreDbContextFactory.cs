using ABP.MVCCore.Configuration;
using ABP.MVCCore.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABP.MVCCore.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MVCCoreDbContextFactory : IDesignTimeDbContextFactory<MVCCoreDbContext>
    {
        public MVCCoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MVCCoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MVCCoreConsts.ConnectionStringName)
            );

            return new MVCCoreDbContext(builder.Options);
        }
    }
}