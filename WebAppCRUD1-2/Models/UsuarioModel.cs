using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class UsuarioModel
    {

        [Required]
        public string email { get; set; }

        [Required]
        public string passw { get; set; }

        public bool vali { get; set; }
    }
}
