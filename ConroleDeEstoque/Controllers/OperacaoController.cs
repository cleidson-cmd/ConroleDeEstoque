using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConroleDeEstoque.Controllers
{
    public class OperacaoController : Controller
    {
        // GET: Operacao
        public ActionResult EntradaProduto()
        {
            return View();
        }

        public ActionResult SaidaProduto()
        {
            return View();
        }

        public ActionResult LancPerdaProduto()
        {
            return View();
        }

        public ActionResult InventarioEstoque()
        {
            return View();
        }
    }
}