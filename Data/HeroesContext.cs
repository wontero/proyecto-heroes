using HeroesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesWeb.Data;

public partial class HeroesContext(DbContextOptions<HeroesContext> options) : DbContext(options)
{
    public virtual DbSet<Heroes> Heroes { get; set; }
    public virtual DbSet<SuperPoderes> SuperPoderes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SuperPoderes>(entity =>
        {
            entity.HasOne(p => p.Heroe)
                .WithMany(h => h.SuperPoderes)
                .HasForeignKey(p => p.HeroeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SuperPoderes_Heroes");
        });
    }
}
