﻿using Microsoft.AspNetCore.Mvc;

namespace MVCFilmes.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BemVindo(string nome, int id)
        {
            ViewData["Title"] = "BVVVVVV";
            return View();
        }
        //$"Olá seja bem-vindo, {nome} - {id}";
    }
}
