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
                    return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", id = comentario.PostagemId });
                }
                return View(comentario);
            }
            catch
            {
                return View(comentario);
            }
        }

        public ActionResult Index(long id)
        {
            IQueryable<Comentario> comentarios = comentarioDAL.ObterComentariosClassificadosPorId();
            List<Comentario> nova_lista = new List<Comentario>();
            foreach (var item in comentarios)
            {
                if (item.PostagemId == id) {
                    nova_lista.Add(item);
                }
            }
            if (nova_lista.Count() == 0)
            {
                Comentario comentario = new Comentario();
                comentario.PostagemId = id;
                nova_lista.Add(comentario);
            }
            
            return View(nova_lista);
        }

        public ActionResult Create(long id)
        {
            Comentario comentario = new Comentario();
            comentario.PostagemId = id;
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
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
                if (ModelState.IsValid)
                {
                    Comentario comentario_id = comentarioDAL.ObterComentarioPorId(id);
                    long postagemId = (long) comentario_id.PostagemId;
                    Comentario comentario = comentarioDAL.EliminarComentarioPorId(id);
                    TempData["Message"] = "Comentário excluído com sucesso";
                    return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", id = postagemId });
                }
                else
                {
                    return RedirectToAction("../Comentário_não_encontrado");
                }
            }
            catch
            {
                return View();
            }
        }

    }
}