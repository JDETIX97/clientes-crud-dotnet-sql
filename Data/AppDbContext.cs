using Microsoft.EntityFrameworkCore;
using ClientesCrud.Models;

namespace ClientesCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}