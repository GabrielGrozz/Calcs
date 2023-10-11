using System.ComponentModel.DataAnnotations;

namespace Calcs.Models
{
    public class CalculateViewModel
    {
        //primeiro valor
        [Display(Name ="Primeiro valor")]
        public double ValueA { get; set; }
        //segundo valor
        [Display(Name ="Segundo valor")]
        public double ValueB { get; set; }
        //operadores: + : - : * : /
        [Display(Name ="Operador")]
        public string? Operator { get; set; }
        //resultado
        [Display(Name ="Resultado")]
        public double Result { get; set; }
    }
}
