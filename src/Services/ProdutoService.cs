using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Models.Entities;

namespace src.Services
{
    public class ProdutoService
    {
        private readonly MeuDbContext _context;

        public ProdutoService(MeuDbContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> ObterTodos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> ObterPorId(int id)
        {
            return await _context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task Adicionar(Produto produto)
        {
            _context.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task Atualizar(Produto produto)
        {
            _context.Update(produto);
            await _context.SaveChangesAsync();
        }
    }
}