using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrantes
    {
        List<Migrantes> Migrantes;
        private readonly AppContext _appContext = new AppContext();   

 
    
        public IEnumerable<Migrantes> GetAll()
        {
            return _appContext.Migrantes;

        }
 
        public Migrantes GetMigranteWithId(int id){
            return _appContext.Migrantes.Find(id);
        }
        public Migrantes Create(Migrantes newMigrante)
        {
           var addMigrante = _appContext.Migrantes.Add(newMigrante);
            _appContext.SaveChanges();
            return addMigrante.Entity;
        }

        public Migrantes Update(Migrantes newMigrante){
            var migrante = _appContext.Migrantes.Find(newMigrante.id);
            if(migrante != null){
                migrante.nombre = newMigrante.nombre;
                migrante.apellidos = newMigrante.apellidos;
                migrante.tipo_documento = newMigrante.tipo_documento;
                migrante.identificacion = newMigrante.identificacion;
                migrante.pais_origen = newMigrante.pais_origen;
                migrante.fecha_nacimiento = newMigrante.fecha_nacimiento;
                migrante.email = newMigrante.email;
                migrante.telefono = newMigrante.telefono;
                migrante.direccion_actual = newMigrante.direccion_actual;
                migrante.ciudad = newMigrante.ciudad;
                migrante.situacion_laboral = newMigrante.situacion_laboral;
                //Guardar en base de datos
                _appContext.SaveChanges();
            }
        return migrante;
        }

       public void Delete(int id)
        {
        var migrante = _appContext.Migrantes.Find(id);
        if (migrante == null)
            return;
        _appContext.Migrantes.Remove(migrante);
        _appContext.SaveChanges();
        }


    }
}
