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
    public class ListMigranteModel : PageModel
    {
       
        private readonly RepositorioMigrantes repositorioMigrantes;
        public IEnumerable<Migrantes> Migrantes {get;set;}
        [BindProperty]
        public Migrantes Migrante {get;set;}
 
    public ListMigranteModel(RepositorioMigrantes repositorioMigrantes)
    {
        this.repositorioMigrantes=repositorioMigrantes;
     }
 
    public void OnGet()
    {
        Migrantes=repositorioMigrantes.GetAll();
    }

     public IActionResult OnPost()
    {
        if(Migrante.id>0)
        {
        repositorioMigrantes.Delete(Migrante.id);
        }
        return RedirectToPage("./List");
    }




    }
}
