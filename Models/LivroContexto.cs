using Microsoft.EntityFrameworkCore;

namespace LivrariaMVC.Models
{
    public class LivroContexto : DbContext
    {
        public LivroContexto(DbContextOptions<LivroContexto> options) : base(options)
        {
        } 
        public DbSet<Livro> Livros { get; set; }
    }
}