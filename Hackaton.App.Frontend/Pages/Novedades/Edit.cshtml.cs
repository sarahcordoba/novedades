using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;
using Microsoft.AspNetCore.Authorization;

namespace Hackaton.App.Frontend.Pages
{
    public class EditNovedadModel : PageModel
    {
        private readonly RepositorioNovedades repositorioNovedades;
        [BindProperty]
        public Novedades Novedad {get;set;}
    public EditNovedadModel(RepositorioNovedades repositorioNovedades)
       {
            this.repositorioNovedades=repositorioNovedades;
       }
    public IActionResult OnGet(int novedadId)
        {
            Novedad=repositorioNovedades.GetNovedadWithId(novedadId);
            return Page(); 
        }

    public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Novedad.id>0)
            {
            Novedad = repositorioNovedades.Update(Novedad);
            }
                return RedirectToPage("./List");
        }

    }
}
