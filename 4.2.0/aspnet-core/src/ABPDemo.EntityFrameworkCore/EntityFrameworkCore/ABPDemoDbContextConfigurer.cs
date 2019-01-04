using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPDemo.EntityFrameworkCore
{
    public static class ABPDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
