using HeroesMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesMvc.Data;

public class HeroesDbContext : DbContext
{
    public HeroesDbContext(DbContextOptions<HeroesDbContext> options)
        : base(options)
    {
    }

    public DbSet<Heroe> Heroes { get; set; }
}
