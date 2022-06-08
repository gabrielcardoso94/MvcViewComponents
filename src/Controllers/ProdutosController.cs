using Microsoft.AspNetCore.Mvc;
using src.Models.Entities;
using src.Services;

namespace src.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutoService _produtoService;

        public ProdutosController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Produto produto)
        {
            await _produtoService.Adicionar(produto);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Editar(int id)
        {
            var produto = await _produtoService.ObterPorId(id);
            return View(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Produto produto)
        {
            await _produtoService.Atualizar(produto);

            return RedirectToAction(nameof(Index));
        }
    }
}