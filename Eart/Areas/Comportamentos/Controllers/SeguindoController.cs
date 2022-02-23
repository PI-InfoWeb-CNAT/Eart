using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Membros.Models;
using Eart.Areas.Comportamentos.Models;
using Eart.Persistencia.DAL;



namespace Eart.Areas.Comportamentos.Controllers
{
    public class SeguindoController : Controller
    {
        MembroDAL membroDAL = new MembroDAL();
        SeguirDAL seguirDAL = new SeguirDAL();

        // GET: Comportamentos/Seguindo

        private ActionResult GravarSeguir(Seguir seguir)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    seguirDAL.GravarSeguir(seguir);
                }
                return View(seguir);
            }
            catch
            {
                return View(seguir);
            }
        }

        private ActionResult GravarMembro(Membro membro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    membroDAL.GravarMembro(membro);
                }
                return View(membro);
            }
            catch
            {
                return View(membro);
            }
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Follow(long id)
        {
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {                
                Seguir seguindo = new Seguir();
                seguindo.Seguindo = membroDAL.ObterMembroPorId(id);
                seguindo.Seguidor = membroLogin;
                seguindo.Seguindo.Cont_Seguidores++;
                seguindo.Seguidor.Cont_Seguindo++;
                GravarMembro(seguindo.Seguidor);
                GravarMembro(seguindo.Seguindo);
                GravarSeguir(seguindo);
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
        }

        public ActionResult Unfollow(long id)
        {
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {
                Seguir seguindo = new Seguir();
                seguindo.Seguindo = membroDAL.ObterMembroPorId(id);
                seguindo.Seguidor = membroLogin;
                seguindo.Seguindo.Cont_Seguidores--;
                seguindo.Seguidor.Cont_Seguindo--;
                GravarMembro(seguindo.Seguidor);
                GravarMembro(seguindo.Seguindo);
                seguirDAL.EliminarSeguirPorId((long)seguindo.SeguirId);
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
        }
    }
}