using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cancion_web.Models
{
    public class cancion
    {
        [Key]
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false , ErrorMessage = "{0} es requerido")]
        public string autor { get; set; }
        [StringLength(200, MinimumLength = 10 , ErrorMessage ="{0} es requerido")]
        public string letra { get; set; }
        [Url]
        [StringLength(100, MinimumLength = 10 , ErrorMessage ="la longitud de {0} debe estar entre {2} y {1}")]
        public string enlace { get; set; }
        


    }
}
