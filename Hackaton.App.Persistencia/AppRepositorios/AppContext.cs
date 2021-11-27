using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio;
 
namespace Hackaton.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Migrantes> Migrantes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Hackaton");
            }
        }
    }
}

