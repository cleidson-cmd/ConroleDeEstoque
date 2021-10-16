using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConroleDeEstoque.Controllers
{
    public class GraficoController : Controller
    {
        // GET: Grafico
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