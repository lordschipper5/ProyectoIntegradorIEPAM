using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCRUD1.Models
{
    public class CursosModel
    {
        [Required]
        public string nombre_c { get; set; }

        [Required]
        public string descripcion { get; set; }

        [Required]
        public string email { get; set; }

        
        public int cursoid { get; set; }
    }

}