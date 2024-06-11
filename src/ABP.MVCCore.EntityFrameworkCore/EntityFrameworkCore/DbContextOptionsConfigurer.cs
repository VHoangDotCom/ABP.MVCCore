using Microsoft.EntityFrameworkCore;

namespace ABP.MVCCore.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MVCCoreDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MVCCoreDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
