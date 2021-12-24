using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Eart.Areas.Membros.Models;
using Eart.Persistencia.DAL;
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
                if (membro != null)
                {
                    if (details.Usuario == membro.Usuario && details.Senha == membro.Senha)
                    {
                        HttpContext.Session["membroLogin"] = membro;
                        return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
                    }
                    else
                    {
                        if (details.Senha != membro.Senha)
                        {
                            ModelState.AddModelError("Senha", "Senha inválida");
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("Usuario", "Usuário inválido");
                }
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

/*if (membro != null)
            {
                if (details.Usuario != membro.Usuario && details.Usuario != null)
                {
                    ModelState.AddModelError("Usuario", "Usuário inválido");
                }
                if (details.Senha != membro.Senha && details.Senha != null)
                {
                    ModelState.AddModelError("Senha", "Senha inválida");
                }
                else
                {
                    HttpContext.Session["membroLogin"] = membro;
                    return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
                }
            }
            else
            {
                if (details.Usuario == null)
                {
                    ModelState.AddModelError("Usuario", "Por favor, insira seu usuário");
                }
                else
                {
                    ModelState.AddModelError("Usuario", "Usuário inválido");
                }
            }
            if (details.Senha == null)
            {
                ModelState.AddModelError("Senha", "Por favor, insira sua senha");
            }*/