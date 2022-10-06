using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class UsuarioModel
    {
        public string Nombre { get; set; }

        [Required(ErrorMessage ="El usuario es Requerido")]
        public string Usuario { get; set; }

        [Required]
        [Range(100, 200)]
        public string Passw { get; set; }
    }
}
