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
                    @ViewData["Error"] = "Algo salió mal con el servidor.";
                    break;
                case 401:
                    @ViewData["Error"] = "No tiene acceso a está página.";
                    break;
                case 403:
                    @ViewData["Error"] = "Está página no es accesible.";
                    break;
                case 404:
                    @ViewData["Error"] = "Está página no existe.";
                    break;
                case 408:
                    @ViewData["Error"] = "Paso Mucho tiempo. Request TimeOut";
                    break;
                case 501:
                    @ViewData["Error"] = "Esto no está implementado en el navegador actual.";
                    break;
                case 502:
                    @ViewData["Error"] = "Ocurrió una congestión en el servidor.";
                    break;
                case 503:
                    @ViewData["Error"] = "No se puede brindar servicio. Servidor Caido.";
                    break;
                default:
                    @ViewData["Error"] = "Ocurrió un error no especificado.";
                    break;
            }
        return Page();
        }
    }
}