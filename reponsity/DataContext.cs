using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.reponsity
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
