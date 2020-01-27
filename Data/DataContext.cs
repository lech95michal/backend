using Microsoft.EntityFrameworkCore;
using SchelterApp.API.Model;

namespace SchelterApp.API.Data
{
    public class DataContext : DbContext  
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}  
        
        public DbSet<Value> Values { get; set; } 

    }
}