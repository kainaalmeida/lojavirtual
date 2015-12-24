using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Repositorio;

namespace WEB.Controllers
{
    public class VitrineController : Controller
    {

        private  ProdutosReposotorio _repositorio;
        public int ProdutosPorPagina = 3;
        // GET: Vitrine
        public ActionResult ListaProdutos(int pagina = 1)
        {
            _repositorio = new ProdutosReposotorio();
            var produtos = _repositorio.Produtos
                .OrderBy(p=>p.Descricao)
                .Skip((pagina-1)*ProdutosPorPagina)
                .Take(ProdutosPorPagina);



            return View(produtos);
        }
    }
}