using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCRUD1.Datos;
using WebAppCRUD1.Models;

namespace WebAppCRUD1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Cursos()
        {
            return View();
        }

        public IActionResult Equipo()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
        UserDatos alumnodatos = new UserDatos();
        public IActionResult Guardar(UserModel oAlumno)
        {
            if (!ModelState.IsValid)
                return View();

            var resp = alumnodatos.Guardar(oAlumno);
            if (resp)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }
    }
}
