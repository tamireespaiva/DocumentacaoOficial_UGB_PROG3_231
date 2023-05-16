using Microsoft.EntityFrameworkCore;
using Relacionamentos.Models;

namespace Relacionamentos.Data.mappings
{
    public static class map
    {
        public static void OnModelCreating(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasMany(e => e.Posts)
                .WithOne(e => e.Blog)
                .HasForeignKey(e => e.BlogId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
