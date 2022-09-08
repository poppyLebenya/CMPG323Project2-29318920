using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ConnectedOffice.Authentication
{
    public class ApplicationDBContext:IdentityDbContext<ApplicationUser>
    {
    
        public ApplicationDBContext(DbContextOptions<Models.ConnectedOfficeContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}

