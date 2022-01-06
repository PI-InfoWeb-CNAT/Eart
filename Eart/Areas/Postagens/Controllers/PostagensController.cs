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
using Eart.Persistencia.DAL;

namespace Eart.Areas.Postagens.Controllers
{
    public class PostagensController : Controller
    {
        PostagemDAL postagemDAL = new PostagemDAL();

        private ActionResult ObterVisaoPostagemPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postagem postagem = postagemDAL.ObterPostagemPorId((long)id);
            if (postagem == null)
            {
                return HttpNotFound();
            }
            return View(postagem);
        }

        private byte[] SetFoto(HttpPostedFileBase foto)
        {
            var bytesFoto = new byte[foto.ContentLength];
            foto.InputStream.Read(bytesFoto, 0, foto.ContentLength);
            return bytesFoto;
        }

        public FileContentResult GetFoto(long id)
        {
            Postagem postagem = postagemDAL.ObterPostagemPorId(id);
            if (postagem != null)
            {
                return File(postagem.Foto, postagem.FotoType);
            }
            return null;
        }

        public ActionResult DownloadFoto(long id)
        {
            Postagem postagem = postagemDAL.ObterPostagemPorId(id);
            FileStream fileStream = new FileStream(Server.MapPath("~/App_Data/" + postagem.FotoNome), FileMode.Create, FileAccess.Write);
            fileStream.Write(postagem.Foto, 0, Convert.ToInt32(postagem.FotoTamanho));
            fileStream.Close();
            return File(fileStream.Name, postagem.FotoType, postagem.FotoNome);
        }

        private ActionResult GravarPostagem(Postagem postagem, HttpPostedFileBase foto = null)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postagem.Data = DateTime.Now;
                    if (foto != null)
                    {
                        postagem.FotoType = foto.ContentType;
                        postagem.Foto = SetFoto(foto);
                        postagem.FotoNome = foto.FileName;
                        postagem.FotoTamanho = foto.ContentLength;
                    }
                    postagemDAL.GravarPostagem(postagem);
                    return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
                }
                return View(postagem);
            }
            catch
            {
                return View(postagem);
            }
        }

        public ActionResult Index()
        {
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            ViewBag.MembroLogado = membroLogin.MembroId;
            return View(postagemDAL.ObterPostagensClassificadasPorId());
        }

        public ActionResult Create()
        {
            Postagem postagem = new Postagem();
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {
                postagem.MembroId = membroLogin.MembroId;
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
            return View(postagem);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Postagem postagem, HttpPostedFileBase foto = null)
        {
            return GravarPostagem(postagem, foto);
        }

        public ActionResult Edit(long? id)
        {
            return ObterVisaoPostagemPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Postagem postagem, HttpPostedFileBase foto = null)
        {
            return GravarPostagem(postagem, foto);
        }

        public ActionResult Details(long? id)
        {
            return ObterVisaoPostagemPorId(id);
        }

        public ActionResult Delete(long? id)
        {
            return ObterVisaoPostagemPorId(id);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Postagem postagem = postagemDAL.EliminarPostagemPorId(id);
                    TempData["Message"] = "Postagem excluída com sucesso";
                    return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
                }
                else
                {
                    return RedirectToAction("../Postagem_não_encontrada");
                }
            }
            catch
            {
                return View();
            }
        }

    }
}