using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPDemo.Authorization.Roles;
using ABPDemo.Authorization.Users;
using ABPDemo.MultiTenancy;

namespace ABPDemo.EntityFrameworkCore
{
    public class ABPDemoDbContext : AbpZeroDbContext<Tenant, Role, User, ABPDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPDemoDbContext(DbContextOptions<ABPDemoDbContext> options)
            : base(options)
        {
        }
    }
}
