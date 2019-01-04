using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPDemo.Configuration;
using ABPDemo.Web;

namespace ABPDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPDemoDbContextFactory : IDesignTimeDbContextFactory<ABPDemoDbContext>
    {
        public ABPDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPDemoConsts.ConnectionStringName));

            return new ABPDemoDbContext(builder.Options);
        }
    }
}
