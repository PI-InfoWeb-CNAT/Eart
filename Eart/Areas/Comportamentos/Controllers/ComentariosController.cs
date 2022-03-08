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
                if (item.PostagemId == idPostagem)
                {
                    nova_lista.Add(item);
                }
            }
            return View(nova_lista);
        }

        public ActionResult Create(long idPostagem, long idIndex)
        {
            if (idIndex == 1)
            {
                ViewBag.IdIndex = 1;
            }
            if (idIndex == 2)
            {
                ViewBag.IdIndex = 2;
            }
            Comentario comentario = new Comentario();
            comentario.PostagemId = idPostagem;
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
        public ActionResult Create(Comentario comentario, long idIndex)
        {
            if (ModelState.IsValid)
            {
                Postagem postagem = postagemDAL.ObterPostagemPorId((long)comentario.PostagemId);
                postagem.Cont_Comentarios += 1;
                GravarPostagem(postagem);
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = idIndex });
            }
            else
            {
                return GravarComentario(comentario);
            }
        }



        public ActionResult Edit(long? idComentario, long idIndex)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comentario comentario, long idIndex)
        {
            if (ModelState.IsValid)
            {
                GravarComentario(comentario);
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = comentario.PostagemId, idIndex = idIndex });
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

        public ActionResult Delete(long? idComentario, long idIndex)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int idComentario, long idIndex, FormCollection collection)
        {
            try
            {
                Comentario comentario_id = comentarioDAL.ObterComentarioPorId(idComentario);
                long postagemId = (long)comentario_id.PostagemId;
                Comentario comentario = comentarioDAL.EliminarComentarioPorId(idComentario);
                Postagem postagem = postagemDAL.ObterPostagemPorId(postagemId);
                postagem.Cont_Comentarios -= 1;
                GravarPostagem(postagem);
                TempData["Message"] = "Comentário excluído com sucesso";
                return RedirectToAction("Index", "Comentarios", new { area = "Comportamentos", idPostagem = postagemId, idIndex = idIndex });
            }
            catch
            {
                return View();
            }
        }
    }
}