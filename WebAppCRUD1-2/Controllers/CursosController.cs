﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCRUD1.Controllers
{
    public class CursosController : Controller
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

        public IActionResult ContenidoCursos()
        {
            return View();
        }

        public IActionResult AddCursos()
        {
            return View();
        }
    }
}
