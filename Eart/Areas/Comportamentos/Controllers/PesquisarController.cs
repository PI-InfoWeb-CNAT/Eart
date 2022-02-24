using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Membros.Models;
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

        public ActionResult PesquisarMembros(string pesquisa)
        {
            IQueryable<Membro> resultados = pesquisaDAL.PesquisarMembros(pesquisa);
            return View(resultados);
        }

        /*public ActionResult PesquisarPostagensPorConteudo(string texto)
        {
            Membro membroLogin = HttpContext.Session["membroLogin"] as Membro;
            ViewBag.MembroLogado = membroLogin.MembroId;
            Pesquisa pesquisa = new Pesquisa();
            IQueryable<Postagem> resultados = pesquisaDAL.PesquisarPostagensPorConteudo(pesquisa.ItemPesquisa);
            return View(resultados);
        }*/

    }
}