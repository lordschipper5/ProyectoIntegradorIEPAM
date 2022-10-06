using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class CursosModel
    {
        public string idCurso { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido")]
        public string NombreCurso { get; set; }

        [Required]
        [Range(100, 200)]
        public string Descripcion { get; set; }
    }
}