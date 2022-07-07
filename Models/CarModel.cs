using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.AspNet3.Models
{
    public class CarModel
    {

        [Display(Name = "Código do Carro")]
        [HiddenInput]
        public int CarrroId { get; set; }


        [Display(Name = "Marca do Carro")]
        [MaxLength(15,ErrorMessage ="Muito Grande")]
        [MinLength(2,ErrorMessage ="Muito Pequeno")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string MarcaCarro { get; set; }


        [Display(Name = "Nome do Carro")]
        [MaxLength(15, ErrorMessage = "Muito Grande")]
        [MinLength(2, ErrorMessage = "Muito Pequeno")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCarro { get; set; }


        [Display(Name = "Modelo do Carro")]
        [MaxLength(15, ErrorMessage = "Muito Grande")]
        [MinLength(2, ErrorMessage = "Muito Pequeno")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string ModeloCarro { get; set; }

        [Display(Name = "Kilometragem do Carro")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int? KmCarro { get; set; }

       
        [Display(Name = "Ano do Carro")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int? AnoCarro { get; set; }

        [Display(Name ="Foto do Carro")]
        public string? FotoCarro { get; set; }

    }
}
