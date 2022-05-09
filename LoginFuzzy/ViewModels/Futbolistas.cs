using LoginFuzzy.Model;
using System.ComponentModel.DataAnnotations;

namespace LoginFuzzy.ViewModels
{
    public class Futbolistas
    {
        public int IdFutbolista { get; set; }
        [Required(ErrorMessage ="Debe ingresar un nombre.")]
        [MinLength(3,ErrorMessage = "El nombre debe contener más de 2 caracteres.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\u00f1\u00d1]+(\s*[a-zA-ZÀ-ÿ\u00f1\u00d1]*)*[a-zA-ZÀ-ÿ\u00f1\u00d1]+$", ErrorMessage = "Sólo se permiten letras.")]
        public string? nombre { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }
        public double musculatura { get; set; }
        public double velocidad { get; set; }
        public double resistencia { get; set; }
        public double agilidad { get; set; }
        public double confianza { get; set; }
        public double concentracion { get; set; }
        public double decisiones { get; set; }
        public double creatividad { get; set; }
        public double dribling { get; set; }
        public double pases { get; set; }
        public double finalizacion { get; set; }
        public double DC { get; set; }
        public double DL { get; set; }
        public double PT { get; set; }
        public double MC { get; set; }
        public double FW { get; set; } 
        public string? Id { get; set; }
    }
}
