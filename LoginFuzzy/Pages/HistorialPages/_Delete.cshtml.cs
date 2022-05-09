using LoginFuzzy.Model;
using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LoginFuzzy.Pages.Shared
{
    [Authorize]
    public class _DeleteModel : PageModel
    {
        private readonly AuthDbContext _authDbContext;
        private readonly UserManager<ApplicationUser> futbolista;
        public _DeleteModel(UserManager<ApplicationUser> futbolista, AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
            this.futbolista = futbolista;
        }

        [BindProperty]
        public Futbolista Futbolista { get; set; }

        public async Task<IActionResult> OnGetDeleteAsync(int id = 0)
        {
            if (id != 0)
            {
                Futbolista = await _authDbContext.Futbolista.FindAsync(id);
            }
            return Page();
        }
        public async Task<IActionResult> OnPostDeletingAsync()
        {
            if (ModelState.IsValid)
            {
                var futbolistafromDB = await _authDbContext.Futbolista.FindAsync(Futbolista.IdFutbolista);
                if(futbolistafromDB != null)
                {
                    _authDbContext.Remove(futbolistafromDB);
                    await _authDbContext.SaveChangesAsync();
                }
                return RedirectToPage("/Historial");
            }
            return RedirectToPage("/Historial");
        }
    }
}
