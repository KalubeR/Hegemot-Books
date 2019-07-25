using System;
using HegemotBooks.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HegemotBooks.Data
{
    public class HegemotBooksDbContext : IdentityDbContext<HegemotBooksUser, HegemotUserRole, string>
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<MembershipCard> MembershipCards { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Receipt> Receipts { get; set; }

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
