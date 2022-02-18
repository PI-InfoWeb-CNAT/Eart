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
        PostagemDAL postagemDAL = new PostagemDAL();

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

        private ActionResult GravarPostagem(Postagem postagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postagem.Relevancia = ((postagem.Cont_Curtidas * 3) + (postagem.Cont_Comentarios * 2)) / 5;
                    postagemDAL.GravarPostagem(postagem);
                }
                return View(postagem);
            }
            catch
            {
                return View(postagem);
            }
        }

        private ActionResult GravarComentario(Comentario comentario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    comentario.Data = DateTime.Now;
                    comentarioDAL.GravarComentario(comentario);   
                }
                return View(comentario);
            }
            catch
            {
                return View(comentario);
            }
        }

        public ActionResult Index(long idPostagem, long idIndex)
        {
            if (idIndex == 1)
            {
                ViewBag.IdIndex = 1;
                ViewBag.UrlAnterior = "~/Postagens/Postagens/FeedMembrosSeguidos";
            }
            if (idIndex == 2)
            {
                ViewBag.IdIndex = 2;
                ViewBag.UrlAnterior = "~/Postagens/Postagens/FeedPorRelevancia";
            }
            ViewBag.IdPostagem = idPostagem;
            IQueryable<Comentario> comentarios = comentarioDAL.ObterComentariosClassificadosPorData();
            List<Comentario> nova_lista = new List<Comentario>();
            foreach (var item in comentarios)
            {
                if (item.PostagemId == idPostagem) {
                    nova_lista.Add(item);
                }
            }
            return View(nova_lista);
        }

        public ActionResult Create1(long id)
        {
            ViewBag.IdIndex = 1;
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
        public ActionResult Create1(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                ViewBag.IdIndex = 1;
                Postagem postagem = postagemDAL.ObterPostagemPorId((long)comentario.PostagemId);
                postagem.Cont_Comentarios += 1;
                GravarPostagem(postagem);
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = 1 });
            }
            else
            {
                return GravarComentario(comentario);
            }
        }

        public ActionResult Create2(long id)
        {
            ViewBag.IdIndex = 2;
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
        public ActionResult Create2(Comentario comentario, long idIndex)
        {
            if (ModelState.IsValid)
            {
                ViewBag.IdIndex = 2;
                Postagem postagem = postagemDAL.ObterPostagemPorId((long)comentario.PostagemId);
                postagem.Cont_Comentarios += 1;
                GravarPostagem(postagem);
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = 2 });
            }
            else
            {
                return GravarComentario(comentario);
            }
        }

        public ActionResult Edit1(long? id)
        {
            ViewBag.IdIndex = 1;
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit1(Comentario comentario)
        {
            ViewBag.IdIndex = 1;
            if (ModelState.IsValid)
            {
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = 1 });
            }
            else
            {
                return GravarComentario(comentario);
            }
        }

        public ActionResult Edit2(long? id)
        {
            ViewBag.IdIndex = 2;
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit2(Comentario comentario)
        {
            if (ModelState.IsValid)
            {
                ViewBag.IdIndex = 2;
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = 2 });
            }
            else
            {
                return GravarComentario(comentario);
            }
        }

        public ActionResult Details(long? idComentario, long idIndex)
        {
            if (idIndex == 1)
            {
                ViewBag.IdIndex = 1;
            }
            if (idIndex == 2)
            {
                ViewBag.IdIndex = 2;
            }
            return ObterVisaoComentarioPorId(idComentario);
        }

        public ActionResult Delete1(long? id)
        {
            ViewBag.IdIndex = 1;
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete1(int id, FormCollection collection)
        {
            try
            {
                ViewBag.IdIndex = 1;
                Comentario comentario_id = comentarioDAL.ObterComentarioPorId(id);
                long postagemId = (long) comentario_id.PostagemId;
                Comentario comentario = comentarioDAL.EliminarComentarioPorId(id);
                Postagem postagem = postagemDAL.ObterPostagemPorId((long) postagemId);
                postagem.Cont_Comentarios -= 1;
                GravarPostagem(postagem);
                TempData["Message"] = "Comentário excluído com sucesso";
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = postagemId, idIndex = 1  });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete2(long? id)
        {
            ViewBag.IdIndex = 2;
            return ObterVisaoComentarioPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete2(int id, FormCollection collection)
        {
            try
            {
                ViewBag.IdIndex = 2;
                Comentario comentario_id = comentarioDAL.ObterComentarioPorId(id);
                long postagemId = (long)comentario_id.PostagemId;
                Comentario comentario = comentarioDAL.EliminarComentarioPorId(id);
                Postagem postagem = postagemDAL.ObterPostagemPorId((long)postagemId);
                postagem.Cont_Comentarios -= 1;
                GravarPostagem(postagem);
                TempData["Message"] = "Comentário excluído com sucesso";
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = postagemId, idIndex = 2 });
            }
            catch
            {
                return View();
            }
        }

    }
}