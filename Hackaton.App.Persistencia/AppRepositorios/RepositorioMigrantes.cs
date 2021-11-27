using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrantes
    {
        List<Migrantes> migrantes;
 
    public RepositorioMigrantes()
        {
            buses= new List<Migrantes>()
            {
                new Buses{id=1,marca="Audi",modelo= 2020,kilometraje= 100000,numero_asientos= 4,placa= "POP678"},
                new Buses{id=2,marca="Toyota",modelo= 2021,kilometraje= 90000,numero_asientos= 16,placa= "OIU859"},
                new Buses{id=3,marca="Mazda",modelo= 2000,kilometraje= 150000,numero_asientos= 24,placa= "YUH859"}
 
            };
        }
 
        public IEnumerable<Migrantes> GetAll()
        {
            return Migrantes;
        }
 
        public Migrantes GetMigrantesWithId(int id){
            return migrantes.SingleOrDefault(b => b.id == id);
        }
    }
}
