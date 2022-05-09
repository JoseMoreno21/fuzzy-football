using System.ComponentModel.DataAnnotations;

namespace LoginFuzzy.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage ="Debe ingresar un nombre de usuario.")]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Debe ingresar una contraseña.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }    
    }
}
