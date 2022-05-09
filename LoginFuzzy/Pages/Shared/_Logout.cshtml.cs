using LoginFuzzy.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginFuzzy.Pages
{
    [Authorize]
    public class _LogoutModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public _LogoutModel(SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
        }
        
        public IActionResult OnGetLogOut()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostLogoutAsync()
        {
            await signInManager.SignOutAsync();
            return RedirectToPage("/Index");
        }
    }
}
