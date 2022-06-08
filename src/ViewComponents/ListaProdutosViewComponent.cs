using Microsoft.AspNetCore.Mvc;
using src.Services;

namespace src.ViewComponents
{
    public class ListaProdutosViewComponent : ViewComponent
    {
        private readonly ProdutoService _produtoService;

        public ListaProdutosViewComponent(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Teste = await _produtoService.ObterTodos();
            return View(Teste);
        }
        
    }
}