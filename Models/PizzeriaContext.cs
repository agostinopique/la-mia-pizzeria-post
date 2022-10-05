using la_mia_pizzeria_static.Models;
using Microsoft.EntityFrameworkCore;

namespace la_mia_pizzeria_static.Models
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Name> Name { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Picture> Picture { get; set; }
        public DbSet<Price> Price { get; set; }
        
        protected override void OnConfigurin(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=la-mia-pizzeria-db;Integrated Security=True");
        }
    }
}
