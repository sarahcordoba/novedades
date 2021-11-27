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
    public class DetailsMigranteModel : PageModel
    {
       private readonly RepositorioMigrantes repositorioMigrantes;
              public Migrantes Migrante {get;set;}
 
        public DetailsMigranteModel(RepositorioMigrantes repositorioMigrantes)
       {
            this.repositorioMigrantes=repositorioMigrantes;
       }
 
        public IActionResult OnGet(int migranteId)
        {
                Migrante=repositorioMigrantes.GetMigranteWithId(migranteId);
                return Page();
 
        }
    }
    }
