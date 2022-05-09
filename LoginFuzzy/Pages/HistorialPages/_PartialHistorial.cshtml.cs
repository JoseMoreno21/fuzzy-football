using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginFuzzy.Pages.Shared
{
    [Authorize]
    public class _PartialHistorialModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
