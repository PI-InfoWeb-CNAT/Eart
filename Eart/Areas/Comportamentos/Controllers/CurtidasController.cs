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
    public class CurtidasController : Controller
    {
        PostagemDAL postagemDAL = new PostagemDAL();
        CurtidaDAL curtidaDAL = new CurtidaDAL();

        private ActionResult ObterVisaoCurtidaPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Curtida curtida = curtidaDAL.ObterCurtidaPorId((long)id);
            if (curtida == null)
            {
                return HttpNotFound();
            }
            return View(curtida);
        }

        private ActionResult GravarPostagem(Postagem postagem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    postagemDAL.GravarPostagem(postagem);
                }
                return View(postagem);
            }
            catch
            {
                return View(postagem);
            }
        }

        private ActionResult GravarCurtida(Curtida curtida)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    curtida.Data = DateTime.Now;
                    curtidaDAL.GravarCurtida(curtida);
                }
                return View(curtida);
            }
            catch
            {
                return View(curtida);
            }
        }


        public ActionResult Curtir(long id)
        {
            
            Postagem postagem = postagemDAL.ObterPostagemPorId(id);
            Curtida curtida = new Curtida();
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {
                curtida.MembroId = membroLogin.MembroId;
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
            //postagem.Curtidas.Add(curtida);

            curtida.PostagemId = id;
            GravarCurtida(curtida);
            postagem.Cont_Curtida += 1;
            GravarPostagem(postagem);
            return RedirectToAction("Index", "Postagens", new { area = "Postagens"});
        }
        public ActionResult Descurtir(long id)
        {
            Postagem postagem = postagemDAL.ObterPostagemPorId(id);
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {
                curtidaDAL.EliminarCurtidaPorId((long)postagem.PostagemId, (long)membroLogin.MembroId);
                postagem.Cont_Curtida -= 1;
                GravarPostagem(postagem);
                return RedirectToAction("Index", "Postagens", new { area = "Postagens" });
            }
            else 
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
        }
    }
}