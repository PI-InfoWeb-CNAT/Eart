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
                curtida.PostagemId = id;
                GravarCurtida(curtida);
                postagem.Cont_Curtidas += 1;
                GravarPostagem(postagem);
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
            
        }
        public ActionResult Descurtir(long id)
        {
            Postagem postagem = postagemDAL.ObterPostagemPorId(id);
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            if (membroLogin != null)
            {
                Curtida curtida = curtidaDAL.EliminarCurtidaPorId((long)postagem.PostagemId, (long)membroLogin.MembroId);
                postagem.Cont_Curtidas -= 1;
                GravarPostagem(postagem);
                return Redirect(Request.UrlReferrer.ToString());
            }
            else 
            {
                return RedirectToAction("Login", "Account", new { area = "Membros" });
            }
        }
    }
}