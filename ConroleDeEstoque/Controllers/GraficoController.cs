using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
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