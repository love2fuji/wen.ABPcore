using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using wen.ABPcore.Authorization.Roles;
using wen.ABPcore.Authorization.Users;
using wen.ABPcore.MultiTenancy;

namespace wen.ABPcore.EntityFrameworkCore
{
    public class ABPcoreDbContext : AbpZeroDbContext<Tenant, Role, User, ABPcoreDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPcoreDbContext(DbContextOptions<ABPcoreDbContext> options)
            : base(options)
        {
        }
    }
}
