using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApp
{
    public static class DatabaseMigrationExtensions
    {
        public static void EnsureContextReady<TDbContext>(this WebApplication app) where TDbContext : DbContext
        {
            using(var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<TDbContext>();
                context.Database.Migrate();
            }
        }
    }
}
