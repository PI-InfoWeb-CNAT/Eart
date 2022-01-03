using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Postagens.Models;
using Eart.Areas.Membros.Models;
using Eart.Areas.Comportamentos.Models;
using Eart.Persistencia.DAL;

namespace Eart.Areas.Comportamentos.Controllers
{
    public class ComentariosController : Controller
    {
        ComentarioDAL comentarioDAL = new ComentarioDAL();

        private ActionResult ObterVisaoComentarioPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comentario comentario = comentarioDAL.ObterComentarioPorId((long)id);
            if (comentario == null)
            {
                return HttpNotFound();
            }
            return View(comentario);
        }

        private ActionResult GravarComentario(Comentario comentario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    comentario.Data = DateTime.Now;
                    comentarioDAL.GravarComentario(comentario);
                    return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
                }
                return View(comentario);
            }
            catch
            {
                return View(comentario);
            }
        }

        public ActionResult Index()
        {
            return View(comentarioDAL.ObterComentariosClassificadosPorId());
        }

        public ActionResult Create(long id)
        {
            Comentario comentario = new Comentario();
            comentario.PostagemId = id;
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin.MembroId != null)
            {
                comentario.MembroId = membroLogin.MembroId;
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
            return View(comentario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comentario comentario)
        {
            return GravarComentario(comentario);
        }

        public ActionResult Edit(long? id)
        {
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comentario comentario)
        {
            return GravarComentario(comentario);
        }

        public ActionResult Details(long? id)
        {
            return ObterVisaoComentarioPorId(id);
        }

        public ActionResult Delete(long? id)
        {
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Comentario comentario = comentarioDAL.EliminarComentarioPorId(id);
                TempData["Message"] = "Comentário excluído com sucesso";
                return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
            }
            catch
            {
                return View();
            }
        }

    }
}