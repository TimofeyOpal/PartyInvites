using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PartyInvites.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
           // Database.EnsureDeleted();   // удаляем бд со старой схемой
            Database.EnsureCreated();
        }
    }
}