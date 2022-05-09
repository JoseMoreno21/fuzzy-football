using LoginFuzzy.Model;
using LoginFuzzy.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace LoginFuzzy.Pages
{
    public class PrivacidadModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly UserManager<ApplicationUser> futbolista;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public PrivacidadModel(ILogger<IndexModel> logger, UserManager<ApplicationUser> futbolista, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            this.futbolista = futbolista;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public void OnGet()
        {
            ViewData["UsuarioNombre"] = futbolista.GetUserName(User);
        }

        public PartialViewResult OnGetLoginA()
        {
            ModelState.Clear();
            return new PartialViewResult
            {
                ViewName = "AuthenticationPages/_Login",
                ViewData = new ViewDataDictionary<Login>(ViewData, new Login { })
            };
        }

        public async Task<IActionResult> OnPostLoginAAsync(Login ModelLog, string? returnUrl = null)
        {
            var errores = ModelState.Values.SelectMany(x => x.Errors);
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(ModelLog.Username, ModelLog.Password, ModelLog.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        TempData["success"] = "Ingresado Correctamente.";
                        //return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Nombre de Usuario o Contraseña Incorrecta.");
                }
            }
            return new PartialViewResult
            {
                ViewName = "AuthenticationPages/_Login",
                ViewData = new ViewDataDictionary<Login>(ViewData, ModelLog)
            };
        }

        public PartialViewResult OnGetRegistroR()
        {
            ModelState.Clear();
            return new PartialViewResult
            {
                ViewName = "AuthenticationPages/_Registro",
                ViewData = new ViewDataDictionary<Registro>(ViewData, new Registro { })
            };
        }

        public async Task<ActionResult> OnPostRegistroRAsync(Registro ModelReg)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = ModelReg.Username,
                    Email = ModelReg.Email
                };
                IdentityResult result = await userManager.CreateAsync(user, ModelReg.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    //return RedirectToPage("Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return new PartialViewResult
            {
                ViewName = "AuthenticationPages/_Registro",
                ViewData = new ViewDataDictionary<Registro>(ViewData, ModelReg)
            };
        }
    }
}