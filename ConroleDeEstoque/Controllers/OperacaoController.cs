using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        [Authorize]
        public ActionResult EntradaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult SaidaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult LancPerdaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult InventarioEstoque()
        {
            return View();
        }
    }
}