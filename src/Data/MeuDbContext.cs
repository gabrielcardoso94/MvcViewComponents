using Microsoft.EntityFrameworkCore;
using src.Models.Entities;

namespace src.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

    }
}