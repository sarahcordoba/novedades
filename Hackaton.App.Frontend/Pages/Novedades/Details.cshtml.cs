using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;
 
namespace Hackaton.App.Frontend.Pages
{
    public class DetailsNovedadModel : PageModel
    {
       private readonly RepositorioNovedades repositorioNovedades;
              public Novedades Novedad {get;set;}
  
        public DetailsNovedadModel(RepositorioNovedades repositorioNovedades)
       {
            this.repositorioNovedades=repositorioNovedades;
       }
 
        public IActionResult OnGet(int novedadId)
        {
                Novedad=repositorioNovedades.GetNovedadWithId(novedadId);
                return Page();
 
        }
    }
}