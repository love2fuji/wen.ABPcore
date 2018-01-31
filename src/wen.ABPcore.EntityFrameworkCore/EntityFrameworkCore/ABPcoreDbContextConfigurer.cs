using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace wen.ABPcore.EntityFrameworkCore
{
    public static class ABPcoreDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPcoreDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPcoreDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
