using System;
using HegemotBooks.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HegemotBooks.Data
{
    public class HegemotBooksDbContext : IdentityDbContext<HegemotBooksUser, HegemotUserRole, string>
    {
        public HegemotBooksDbContext(DbContextOptions<HegemotBooksDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<HegemotBooksUser>()
                .HasOne(u => u.MembershipCard)
                .WithOne(x => x.Owner);

            base.OnModelCreating(builder);
        }
    }
}
