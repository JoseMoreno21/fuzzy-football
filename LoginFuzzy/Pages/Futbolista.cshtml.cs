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

namespace LoginFuzzy.Pages
{
    [Authorize]
    public class FutbolistaModel : PageModel
    {
        
        private readonly AuthDbContext _authDbContext;
        private readonly UserManager<ApplicationUser> futbolista;
        public FutbolistaModel(UserManager<ApplicationUser> futbolista, AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
            this.futbolista = futbolista;
        }

        [BindProperty]
        public Futbolistas Model { get; set; }
        

        public void OnGet()
        {
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                if (await _authDbContext.Futbolista.Where(x => x.Id == futbolista.GetUserId(User) && x.nombre == Model.nombre).CountAsync() == 0)
                {
                    FindPositionMCIFuzzyMC MC = new FindPositionMCIFuzzyMC();
                    FindPositionDLIFuzzyDL DL = new FindPositionDLIFuzzyDL();
                    FindPositionPTIFuzzyPT PT = new FindPositionPTIFuzzyPT();
                    FindPositionDCIFuzzyDC DC = new FindPositionDCIFuzzyDC();
                    FindPositionFWIFuzzyFW FW = new FindPositionFWIFuzzyFW();
                    Model.Id = futbolista.GetUserId(User);
                    Model.MC = Math.Round(MC.FindFuzzyMC(Model.decisiones, Model.resistencia, Model.agilidad, Model.confianza, Model.creatividad, Model.pases), 2);
                    Model.DL = Math.Round(DL.FindFuzzyDL(Model.resistencia, Model.velocidad, Model.agilidad, Model.pases), 2);
                    Model.PT = Math.Round(PT.FindFuzzyPT(Model.altura, Model.peso, Model.musculatura, Model.decisiones, Model.agilidad, Model.confianza), 2);
                    Model.DC = Math.Round(DC.FindFuzzyDC(Model.altura,Model.peso,Model.musculatura,Model.decisiones,Model.concentracion,Model.resistencia), 2);
                    Model.FW = Math.Round(FW.FindFuzzyFW(Model.resistencia,Model.velocidad,Model.agilidad,Model.confianza,Model.finalizacion,Model.dribling,Model.pases),2);
                    var entry = _authDbContext.Futbolista.Add(new Model.Futbolista());
                    entry.CurrentValues.SetValues(Model);
                    await _authDbContext.SaveChangesAsync();
                    return Page();
                }
                ModelState.AddModelError("", "El nombre ya existe. Por favor elija otro.");
            }
            return Page();
        }
    }
}