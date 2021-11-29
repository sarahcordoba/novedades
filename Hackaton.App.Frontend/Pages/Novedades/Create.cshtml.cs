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
    public class FormNovedadModel : PageModel
    { 
        private readonly RepositorioNovedades repositorioNovedades;
        [BindProperty]
        public Novedades Novedad {get;set;}
    public FormNovedadModel(RepositorioNovedades repositorioNovedades)
       {
            this.repositorioNovedades=repositorioNovedades;
       }

    public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            
            Novedad = repositorioNovedades.Create(Novedad);
            
                return RedirectToPage("./List");
        }

    }
}
