using AuditTrialTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AuditTrialTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).IsRequired().UseIdentityColumn();
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.Description).IsRequired();
                entity.Property(e => e.Author).IsRequired();
            });
        }
    }
}
