using Microsoft.AspNetCore.Mvc;
using WebAppCRUD1.Datos;
using WebAppCRUD1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCRUD1.Controllers
{
    public class MantenedorController : Controller
    {
        UserDatos alumnodatos = new UserDatos();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var oLista = alumnodatos.Listar();
            return View(oLista);
        }


        public IActionResult Valiadmin(UsuarioModel oUsuario)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Login", "Login");

            var admin_vali = alumnodatos.Valiadmin(oUsuario.email, oUsuario.passw, oUsuario.vali);

            if (admin_vali == 1)
            {
                return RedirectToAction("Listar", "Mantenedor");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }

        public IActionResult Validar(UsuarioModel oUsuario)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("Login", "Login");

            var bandera = alumnodatos.Validar(oUsuario.email, oUsuario.passw);

            if (bandera == 1)
            {
                return RedirectToAction("Cursos", "Cursos");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }

        }

        public IActionResult Guardar(UserModel oAlumno)
        {
            if (!ModelState.IsValid)
                return View();

            var resp = alumnodatos.Guardar(oAlumno);
            if (resp)
            {
                return RedirectToAction("Cursos","Cursos");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Insertar(UserModel oAlumno)
        {
            if (!ModelState.IsValid)
                return View();

            var resp = alumnodatos.Guardar(oAlumno);
            if (resp)
            {
                return RedirectToAction("Listar", "Mantenedor");
            }
            else
            {
                return View();
            }
        }


        public IActionResult Cursos()
        {
            //if (!ModelState.IsValid)
            return View();

            //var resp = alumnodatos.Guardar(oAlumno);
            //if (resp)
            //{
            //    return RedirectToAction("Cursos");
            //}
            //else
            //{
            //    return View();
            //}
        }

        public IActionResult Editar(int IdAlumno)
        {
            var oAlumno = alumnodatos.Obtener(IdAlumno);
            return View(oAlumno);
        }
        [HttpPost]
        public IActionResult Editar(UserModel oAlumno)
        {
            if (!ModelState.IsValid)
                return View();

            var respuesta = alumnodatos.Editar(oAlumno);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
                return View();
        }

        public IActionResult Eliminar(int IdAlumno)
        {
            var oAlumno = alumnodatos.Obtener(IdAlumno);
            return View(oAlumno);
        }
        [HttpPost]
        public IActionResult Eliminar(UserModel oAlumno)
        {
            var respuesta = alumnodatos.Eliminar(oAlumno.u_id);

            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
                return View();
        }

        public IActionResult AddCursos(CursosModel oAlumnocurso)
        {
            if (!ModelState.IsValid)
                return View();

            var resp = alumnodatos.AddCursos(oAlumnocurso);
            if (resp)
            {
                return RedirectToAction("Cursos", "Cursos");
            }
            else
            {
                return View();
            }
        }
    }
}
