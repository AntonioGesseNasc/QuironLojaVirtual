using System.Web.Mvc;
using Quiron.LojaVirtual.Web.V2.Models;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.V2.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult TesteMetodoVitrine()
        {
            ProdutoModeloRepositorio repositorio = new ProdutoModeloRepositorio();

            var produtos = repositorio.ObterProdutosVitrine(modadelidade: "0051");

            return Json(produtos, JsonRequestBehavior.AllowGet);

        }

        [Route("nav/{id}/{marca}")]
        public ActionResult ObterProdutosPorMarcas(string id)
        {
            var model = new ProdutosViewModel { Produtos = null };

            return View("Index", model);
        }
    }
}