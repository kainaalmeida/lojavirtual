using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidade;

namespace Dominio.Repositorio
{
    public class ProdutosReposotorio
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

        public void Incluir(Produto p)
        {
            _context.Produtos.Add(p);
            _context.SaveChanges();
        }
        
    }
}
