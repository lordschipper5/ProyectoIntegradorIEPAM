using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class UserModel
    {  
        [Required(ErrorMessage ="El Nombre del Alumno es requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "Pon tu Apellido Paterno")]
        public string apellidop { get; set; }

        [Required(ErrorMessage = "Pon tu Apellido Materno")]
        public string apellidom { get; set; }

        [Required(ErrorMessage = "La edad es requerida y debe estar entre 18 y 99")]
        [Range(18, 99)]
        public int edad { get; set; }

        [Required(ErrorMessage = "Ingresa un email")]
        public int email { get; set; }

        [Required(ErrorMessage = "Ingresa una contraseña")]
        public string passw { get; set; }
    }
}
