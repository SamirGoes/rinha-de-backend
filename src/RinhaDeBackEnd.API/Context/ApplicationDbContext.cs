using Microsoft.EntityFrameworkCore;
using RinhaDeBackEnd.API.Models;

namespace RinhaDeBackEnd.API.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transacao>(entity => {
                entity.ToTable("transacoes");

                entity.HasKey(p => p.id);

            });
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Transacao> Transacoes { get; set; }
    }
} 