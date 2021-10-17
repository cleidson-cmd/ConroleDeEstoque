
using ConroleDeEstoque.Models;
using ControleDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ControleDeEstoque.Controllers
{
    public class ContaController : Controller
    {
        #region guarda url que o usuario tentou acessar antes do login
        //guarda a url de onde o usuario tentou acessar na variavel returnurl
        //AllowAnonymous permite qualquer um que não seja anonimo possa acessar
        [AllowAnonymous]
        public ActionResult Login(String returnUrl)
        {
            //guarda na viewbag e assim que  usuario for logado ele ser redirecionado a pagina que havia tentado acessar antes de logar
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        #endregion


        #region valida dados de login
        //verifica se os dados de login estão corretos caso não mostra a tela de login novamente
        //HttpPost para identificar qual é post
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel Login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(Login);
            }

            //exeplo de usuario cadastrado
            var achou = UsuarioModel.ValidarUsuario(Login.Usuario, Login.Senha);

            /*
             * se usuario for cadastrado gera o cookie de autenticação do usuario usando o formsauthentication**/
            if (achou)
            {
                FormsAuthentication.SetAuthCookie(Login.Usuario, Login.LembrarMe);
                //verifica se a url que o usuario tentou acessar antes de fazer login existe 
                if (Url.IsLocalUrl(returnUrl))
                {
                    //se a url existir redireciona a url que o usuario tentou acessar
                    return Redirect(returnUrl);
                }
                else
                {
                    //se a url não existir redireciona par pagina Home
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                //se o login nao for valido da um alerta
                ModelState.AddModelError("", "Login Invalido");
            }

            return View(Login);
        }
        #endregion


        #region logOut
        //desconectar ogin
        [HttpPost]
        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        #endregion

    }
}