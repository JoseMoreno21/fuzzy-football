using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginFuzzy.Pages.Shared
{
    [Authorize]
    public class _ExplicacionFlujoModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnGetVideoExplicado()
        {
            return Page();
        }
    }
}
