using System;
using Microsoft.AspNetCore.Mvc;
using LivrariaMVC.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LivrariaMVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly LivroContexto _contexto;

        private bool LivroExiste(int id) => _contexto.Livros.Any(l => l.Id == id); 
        public LivrosController(LivroContexto contexto) => _contexto = contexto;
        public async Task<IActionResult> Index() => View(await _contexto.Livros.ToListAsync());
        public async Task<IActionResult> Editar(int? id)
        {
            if(id == null)
                return NotFound();

            var livro = await _contexto.Livros.SingleOrDefaultAsync(l => l.Id == id);
            
            if(livro == null)
                return NotFound();

            return View(livro);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int? id, [Bind("Id, Nome, Autor, Preco, Lancamento")] Livro livro)
        {
            if (id != livro.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _contexto.Update(livro);
                    await _contexto.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if (!LivroExiste(livro.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction("Index");
            }
            return View(livro);
        }
        [HttpGet]
        public JsonResult GetLivros(){
            var list = _contexto.Livros.ToListAsync();
            return Json(list);
        }

    }
}