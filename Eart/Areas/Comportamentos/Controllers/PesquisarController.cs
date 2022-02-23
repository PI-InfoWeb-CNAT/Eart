using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Postagens.Models;
using Eart.Areas.Membros.Models;
using Eart.Areas.Comportamentos.Models;
using Eart.Persistencia.DAL;

namespace Eart.Areas.Comportamentos.Controllers
{
    public class PesquisarController : Controller
    {
        PesquisaDAL pesquisaDAL = new PesquisaDAL();

        public ActionResult Index()
        {
            return View();
        }

        // GET: Comportamentos/Pesquisar
        public ActionResult PesquisarMembroPorNome()
        {
            Pesquisa pesquisa = new Pesquisa();
            IQueryable<Membro> resultados = pesquisaDAL.PesquisarMembrosPorNome(pesquisa.ItemPesquisa);
            return View(resultados);
        }

        public ActionResult PesquisarMembroPorUsuario()
        {
            Pesquisa pesquisa = new Pesquisa();
            IQueryable<Membro> resultados = pesquisaDAL.PesquisarMembrosPorUsuario(pesquisa.ItemPesquisa);
            return View(resultados);
        }

        public ActionResult PesquisarPostagensPorConteudo(string texto)
        {
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            ViewBag.MembroLogado = membroLogin.MembroId;
            Pesquisa pesquisa = new Pesquisa();
            IQueryable<Postagem> resultados = pesquisaDAL.PesquisarPostagensPorConteudo(pesquisa.ItemPesquisa);
            return View(resultados);
        }

    }
}