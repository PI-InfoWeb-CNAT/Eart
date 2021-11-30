using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Eart.Areas.Membros.Models;
using Eart.Persistencia.DAL;
//using Eart.Infraestrutura;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Net;

namespace Eart.Areas.Membros.Controllers
{
    public class AccountController : Controller
    {
        MembroDAL membroDAL = new MembroDAL();
        // Propriedades
        private IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
        /*private GerenciadorUsuario UserManager
        {
            get
            {
                return HttpContext.GetOwinContext().GetUserManager<GerenciadorUsuario>();
            }
        }*/


        // Metodos
        public ActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel details, string usuario)
        {
            if (ModelState.IsValid)
            {
                Membro membro = membroDAL.ObterMembroPorUsuario(usuario);
                if (details.Usuario != membro.Usuario && details.Senha != membro.Senha)
                {
                    ModelState.AddModelError("", "Usuário ou senha inválido(s).");
                }
                else
                {
                    return RedirectToAction("Index", "Membros", new { area = "Membros" });
                }
                /*Usuario user = UserManager.Find(details.Usuario, details.Senha);
                if (user == null)
                {
                    ModelState.AddModelError("", "Usuário ou senha inválido(s).");
                }
                else
                {
                    ClaimsIdentity ident = UserManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthManager.SignOut();
                    AuthManager.SignIn(new AuthenticationProperties { IsPersistent = false }, ident);
                    if (returnUrl == null)
                        returnUrl = "/Account";
                    return Redirect(returnUrl);
                }*/
            }
            return View(details);
        }


        public ActionResult Logout()
        {
            AuthManager.SignOut();
            return RedirectToAction("Login", "Account", new { area = "Membros" });
        }
    }
}