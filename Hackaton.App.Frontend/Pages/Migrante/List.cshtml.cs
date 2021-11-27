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
        private readonly RepositorioMigrante repositorioMigrantes;
        public IEnumerable<Migrante> Migrantes { get; set; }

        public ListMigranteModel(RepositorioMigrante repositorioMigrantes)
        {
            this.repositorioMigrantes = repositorioMigrantes;
        }

    
        public void OnGet()
        {
            Migrantes = repositorioMigrantes.GetAll();

        }
    }
}
