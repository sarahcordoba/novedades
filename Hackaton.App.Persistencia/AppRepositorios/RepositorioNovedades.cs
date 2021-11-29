using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioNovedades
    {
        List<Novedades> novedades;
        private readonly AppContext _appContext = new AppContext();
 
    public IEnumerable<Novedades> GetAll()
    {
       return _appContext.Novedades;
    }
 
    public Novedades GetNovedadWithId(int id){
        return _appContext.Novedades.Find(id);
    }

    public Novedades Create(Novedades newNovedad)
        {
           var addNovedad = _appContext.Novedades.Add(newNovedad);
            _appContext.SaveChanges();
            return addNovedad.Entity;
        }

    public void Delete(int id)
        {
        var novedad = _appContext.Novedades.Find(id);
        if (novedad == null)
            return;
        _appContext.Novedades.Remove(novedad);
        _appContext.SaveChanges();
        }

    public Novedades Update(Novedades newNovedad){
            var novedad = _appContext.Novedades.Find(newNovedad.id);
            if(novedad != null){
                novedad.fecha_de_novedad = newNovedad.fecha_de_novedad;
                novedad.dias_novedad_activa = newNovedad.dias_novedad_activa;
                novedad.texto_explicativo = newNovedad.texto_explicativo;
                _appContext.SaveChanges();
            }
        return novedad;
        }
    }
}