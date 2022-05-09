using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginFuzzy.Model
{
    public class Futbolista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFutbolista { get; set; }
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

        //Otras Keys
        [MaxLength(450)]
        public string? Id { get; set; }
        [ForeignKey("Id")]
        public virtual ApplicationUser? ApplicationUser { get; set; }

    }
}
