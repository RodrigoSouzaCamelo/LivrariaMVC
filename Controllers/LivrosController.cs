using System;
using Microsoft.AspNetCore.Mvc;
using LivrariaMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LivrariaMVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroContexto _contexto;

        public LivrosController(LivroContexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Livros.ToListAsync());
        }
    }
}