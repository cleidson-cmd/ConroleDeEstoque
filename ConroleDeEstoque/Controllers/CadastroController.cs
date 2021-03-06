using ControleDeEstoque.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class CadastroController : Controller
    {

        private static List<GrupoProdutoModel> _listagrupoProduto = new List<GrupoProdutoModel>(){
            new GrupoProdutoModel() {Id=1, Nome="mouse", Ativo=true},
            new GrupoProdutoModel() {Id=2, Nome="livro", Ativo=false },
            new GrupoProdutoModel() {Id=3, Nome="teclado", Ativo=true }
        };


// GET: Cadastro
//Authorize só quem tem permissão pode acessar
        [Authorize]
        public ActionResult GrupoProduto()
        {
            return View(_listagrupoProduto);
        }

        [Authorize]
        public ActionResult MarcaProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult LocalProduto()
        {
            return View();
        }

        [Authorize]
        public ActionResult UnidadeMedida()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }

        [Authorize]
        public ActionResult Pais()
        {
            return View();
        }

        [Authorize]
        public ActionResult Estado()
        {
            return View();
        }

        [Authorize]
        public ActionResult Cidade()
        {
            return View();
        }

        [Authorize]
        public ActionResult Fornecedor()
        {
            return View();
        }

        [Authorize]
        public ActionResult PerfilUsuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }
    }
}