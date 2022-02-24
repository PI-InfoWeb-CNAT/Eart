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
                Seguir seguir = new Seguir();
                seguir.SeguindoId = id;
                seguir.SeguidorId = membroLogin.MembroId;
                Membro seguindo = membroDAL.ObterMembroPorId(id);
                Membro seguidor = membroLogin;
                seguindo.Cont_Seguidores++;
                seguidor.Cont_Seguindo++;
                GravarMembro(seguindo);
                GravarMembro(seguidor);
                GravarSeguir(seguir);
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
                Seguir seguir = new Seguir();
                seguir.SeguindoId = id;
                seguir.SeguidorId = membroLogin.MembroId;
                Membro seguindo = membroDAL.ObterMembroPorId(id);
                Membro seguidor = membroLogin;
                seguindo.Cont_Seguidores--;
                seguidor.Cont_Seguindo--;
                GravarMembro(seguindo);
                GravarMembro(seguidor);
                seguirDAL.EliminarSeguirPorId((long)seguir.SeguirId);
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
        }
    }
}