using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Calcs.Models
{
    public class CalculateBhaskaraViewModel
    {
        [Display(Name ="Valor A")]
        public double ValueA { get; set; }
        [Display(Name = "Valor B")]
        public double ValueB { get; set; }
        [Display(Name = "Valor C")]
        public double ValueC { get; set; }
        [Display(Name = "Resultado do primeiro X")]
        public double X1 { get; set; }
        [Display(Name = "Resultado do segundo X")]
        public double X2 { get; set; }
    }
}
