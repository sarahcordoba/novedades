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
    public class ListNovedadModel : PageModel
    {
       
        private readonly RepositorioNovedades repositorioNovedades;
        public IEnumerable<Novedades> Novedades {get;set;}
        [BindProperty]
        public Novedades Novedad {get;set;}

 
    public ListNovedadModel(RepositorioNovedades repositorioNovedades)
    {
        this.repositorioNovedades=repositorioNovedades;
     }
 
    public void OnGet()
    {
        Novedades=repositorioNovedades.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Novedad.id>0)
        {
        repositorioNovedades.Delete(Novedad.id);
        }
        return RedirectToPage("./List");
    }

    }
}
