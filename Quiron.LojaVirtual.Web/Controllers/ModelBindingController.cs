using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: ModelBinding
        public ActionResult Index()
        {
            return View(new Pessoa() );
        }

        // Forma implícita
        //public ActionResult Editar(Produto prod)
        //{
        //    var produto = new Produto();

        //    produto.Nome = prod.Nome;
        //    produto.Preco = prod.Preco;

        //    return RedirectToAction("Index");

        //}
        
        // Formas explícigas (2)
        public ActionResult Editar()
        {
            var pessoa = new Pessoa();

            // uma é o UpdateModel
            // UpdateModel(pessoa);

            // Outra é TryValidateModel
            TryValidateModel(pessoa);

            return RedirectToAction("Index");

        }
    }
}