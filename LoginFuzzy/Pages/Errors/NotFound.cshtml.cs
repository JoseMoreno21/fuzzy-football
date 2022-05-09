using LibraryFuzzyDL;
using LibraryFuzzyPT;
using LibraryFuzzyMC;
using LibraryFuzzyDC;
using LibraryFuzzyFW;
using LoginFuzzy.Model;
using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LoginFuzzy.Pages.Shared
{
    public class NotFoundModel : PageModel
    {
        public IActionResult OnGet(int? statusCode=null)
        {
            switch (statusCode)
            {
                case 400:
                    @ViewData["Error"] = "Algo sali� mal con el servidor.";
                    break;
                case 401:
                    @ViewData["Error"] = "No tiene acceso a est� p�gina.";
                    break;
                case 403:
                    @ViewData["Error"] = "Est� p�gina no es accesible.";
                    break;
                case 404:
                    @ViewData["Error"] = "Est� p�gina no existe.";
                    break;
                case 408:
                    @ViewData["Error"] = "Paso Mucho tiempo. Request TimeOut";
                    break;
                case 501:
                    @ViewData["Error"] = "Esto no est� implementado en el navegador actual.";
                    break;
                case 502:
                    @ViewData["Error"] = "Ocurri� una congesti�n en el servidor.";
                    break;
                case 503:
                    @ViewData["Error"] = "No se puede brindar servicio. Servidor Caido.";
                    break;
                default:
                    @ViewData["Error"] = "Ocurri� un error no especificado.";
                    break;
            }
        return Page();
        }
    }
}