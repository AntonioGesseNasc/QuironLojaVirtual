using System.Collections.Generic;
using System.Linq;
using Quiron.LojaVirtual.Dominio.Entidades;
using Quiron.LojaVirtual.Dominio.Entidades.Vitrine;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class MenuRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Categoria> ObterCategorias()
        {
            return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
        }

        /// <summary>
        /// Obter algumas marcas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<MarcaVitrine> ObterMarcas()
        {
            return _context.MarcaVitrine.OrderBy(m => m.MarcaDescricao);
        }

        public IEnumerable<ClubesNacionais> ObterClubesNacionais()
        {
            return _context.ClubesNacionais.OrderBy(c => c.LinhaDescricao);
        }

        public IEnumerable<ClubesInternacionais> ObterClubesInternacionais()
        {
            return _context.ClubesInternacionais.OrderBy(c => c.LinhaDescricao);
        }

        public IEnumerable<Selecoes> ObterSelecoes()
        {
            return _context.Selecoes.OrderBy(c => c.LinhaDescricao);
        }

    }
}
