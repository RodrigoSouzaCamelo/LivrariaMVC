using System;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaMVC.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}