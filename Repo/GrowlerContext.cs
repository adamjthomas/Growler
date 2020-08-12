using Growler.Models;
using Microsoft.EntityFrameworkCore;

namespace Growler.Repo
{
    public class GrowlerContext : DbContext
    {
        public GrowlerContext(DbContextOptions<GrowlerContext> opt) : base(opt)
        {
        }

        public DbSet<Brew> Brews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Style> Styles { get; set; }
    }
}