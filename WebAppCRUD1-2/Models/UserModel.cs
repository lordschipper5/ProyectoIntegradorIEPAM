using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebAppCRUD1.Models
{
    public class UserModel
    {  
        [Required]
        public string nombre { get; set; }

        [Required]
        public string apellidop { get; set; }

        [Required]
        public string apellidom { get; set; }

        [Required]
        [Range(18, 99)]
        public int edad { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string passw { get; set; }

        [Required]
        public bool vali { get; set; }

        public int u_id { get; set; }
    }
}
