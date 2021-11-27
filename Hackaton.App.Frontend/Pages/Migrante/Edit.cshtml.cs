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
    public class EditMigranteModel : PageModel
    {
        private readonly RepositorioMigrantes repositorioMigrantes;

        [BindProperty]
        public Migrantes Migrante {get; set;}

        public EditMigranteModel(RepositorioMigrantes repositorioMigrantes)
        {
            this.repositorioMigrantes = repositorioMigrantes;
        }

        public IActionResult OnGet(int migranteId)
        {
            Migrante = repositorioMigrantes.GetMigranteWithId(migranteId);
            return Page();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Migrante.id>0)
            {
                Migrante = repositorioMigrantes.Update(Migrante);
            }
            return RedirectToPage("./List");
        }

    }
}
