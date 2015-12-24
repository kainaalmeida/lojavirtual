using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio.Entidade;
using Dominio.Repositorio;

namespace WEB.Controllers
{
    public class ProdutoController : Controller
    {
        public ProdutosReposotorio _repositorio;
        // GET: Produto
        public ActionResult Index()
        {
            _repositorio = new ProdutosReposotorio();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto p)
        {
            _repositorio = new ProdutosReposotorio();
            _repositorio.Incluir(p);
            return View("Create");
        }
    }
}