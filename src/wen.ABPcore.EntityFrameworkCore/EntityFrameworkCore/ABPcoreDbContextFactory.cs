using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using wen.ABPcore.Configuration;
using wen.ABPcore.Web;

namespace wen.ABPcore.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPcoreDbContextFactory : IDesignTimeDbContextFactory<ABPcoreDbContext>
    {
        public ABPcoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPcoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPcoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPcoreConsts.ConnectionStringName));

            return new ABPcoreDbContext(builder.Options);
        }
    }
}
