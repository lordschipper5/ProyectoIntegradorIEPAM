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

        //public IActionResult Listar()
        //{
        //    var oLista = alumnodatos.Listar();
        //    return View(oLista);
        //}

        //public IActionResult Guardar()
        //{
        //    return View();
        //}
        //[HttpPost]

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
        
        //public IActionResult Editar(int IdAlumno)
        //{
        //    var oAlumno = alumnodatos.Obtener(IdAlumno);
        //    return View(oAlumno);
        //}
        //[HttpPost]
        //public IActionResult Editar(UserModel oAlumno)
        //{
        //    if (!ModelState.IsValid)
        //        return View();

        //    var respuesta = alumnodatos.Editar(oAlumno);

        //    if (respuesta)
        //    {
        //        return RedirectToAction("Listar");
        //    }
        //    else
        //        return View();
        //}

        //public IActionResult Eliminar(int IdAlumno)
        //{
        //    var oAlumno = alumnodatos.Obtener(IdAlumno);
        //    return View(oAlumno);
        //}
        //[HttpPost]
        //public IActionResult Eliminar(UserModel oAlumno)
        //{
        //    var respuesta = alumnodatos.Eliminar(oAlumno.IdAlumno);

        //    if (respuesta)
        //    {
        //        return RedirectToAction("Listar");
        //    }
        //    else
        //        return View();
        //}

        //public IActionResult Validar(UsuarioModel oUsuario)
        //{
        //    var bandera = alumnodatos.Validar(oUsuario.Usuario, oUsuario.Passw);
        //    if(bandera == 1)
        //    {
        //        return RedirectToAction("Listar");                 
        //    }
        //    else
        //    {
        //        return View();
        //    }            

        //}
    }
}
