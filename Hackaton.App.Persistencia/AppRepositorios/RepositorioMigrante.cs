using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;

namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrante
    {

        List<Migrante> migrantes;
        private readonly AppContext _appContext = new AppContext();


        public IEnumerable<Migrante> GetAll()
        {

            return _appContext.Migrantes;// retorna la informacion que se encuentra en aviones(base de datos)
        }

        public Migrante Create(Migrante newMigrante)
        {

            var addMigrante = _appContext.Migrantes.Add(newMigrante);
            _appContext.SaveChanges();
            return addMigrante.Entity;
        }

        public Migrante GetMigranteWithId(int Id)
        {

            return _appContext.Migrantes.Find(Id);
        }

        public Migrante Update(Migrante newMigrante)
        {
            var migrante = _appContext.Migrantes.Find(newMigrante.id);
            if (migrante != null)
            {
                migrante.nombre = newMigrante.nombre;
                migrante.apellidos = newMigrante.apellidos;
                migrante.tipo_documento = newMigrante.tipo_documento;
                migrante.identificacion = newMigrante.identificacion;
                migrante.fecha_nacimiento = newMigrante.fecha_nacimiento;
                migrante.email = newMigrante.email;
                migrante.telefono = newMigrante.telefono;
                migrante.direccion_actual = newMigrante.direccion_actual;
                migrante.ciudad = newMigrante.ciudad;
                migrante.situacion_laboral = newMigrante.pais_origen;

                _appContext.SaveChanges(); //Guarda en base de Datos
            }
            return migrante;
        }

        public void Delete(int Id)
        {

            var migrante = _appContext.Migrantes.Find(Id);
            if (migrante == null)
                return;
            _appContext.Migrantes.Remove(migrante);
            _appContext.SaveChanges();
        }

    }
}
