using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace parcial2naipe.Models
{
    public class Naipe
    {


        [Key]
        [Display(Name = "ID del naipe")]
        public int IdCancion { get; set; }



        [Required] //primero las condiciones
        [Display(Name = "Nombre de Carta")]
        public string NombreCarta { get; set; }


        [Url] 
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Ingrese Enlace de la cancion")]
        [Display(Name = "Enlace")]
        public string EnlaceCarta { get; set; }
    }
}
