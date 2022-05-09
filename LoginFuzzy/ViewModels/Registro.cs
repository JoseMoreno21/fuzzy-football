using System.ComponentModel.DataAnnotations;

namespace LoginFuzzy.ViewModels
{
    public class Registro
    {
        [Required(ErrorMessage ="Debe ingresar un nombre de usuario.")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Debe ingresar un correo electrónico.")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^((([!#$%&'*+\-/=?^_`{|}~\w])|([!#$%&'*+\-/=?^_`{|}~\w][!#$%&'*+\-/=?^_`{|}~\.\w]{0,}[!#$%&'*+\-/=?^_`{|}~\w]))[@]\w+([-.]\w+)*\.\w+([-.]\w+)*)$", ErrorMessage ="Ingrese un correo electrónico válido.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar una contraseña.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Debe ingresar la confirmación de la contraseña.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="Las contraseñas no coinciden.")]
        public string? ConfirmPassword { get; set; }
    }
}
