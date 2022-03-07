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
    public class PesquisaController : Controller
    {
        PesquisaDAL pesquisaDAL = new PesquisaDAL();

        public ActionResult PesquisarMembros()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PesquisarMembros(string pesquisa)
        {
            IQueryable<Membro> resultados = pesquisaDAL.PesquisarMembros(pesquisa);
            if (resultados.Count() == 0)
            {
                Membro membro = new Membro();
                resultados.Append(membro);
            }
            return View(resultados);
        }
    }
}