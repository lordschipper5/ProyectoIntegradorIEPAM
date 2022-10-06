using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class AlumnoModel
    {
        [Required(ErrorMessage ="El IdAlumno es requerido")]
        public int IdAlumno { get; set; }
       
        [Required(ErrorMessage ="El Nombre del Alumno es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La ciudad del Alumno es requerido")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage ="La edad es requerida y debe estar entre 18 y 99")]
        [Range(18,99)]
        public int Edad { get; set; }   
    }
}
