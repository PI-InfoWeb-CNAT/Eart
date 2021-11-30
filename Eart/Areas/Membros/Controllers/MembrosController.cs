using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eart.Areas.Membros.Models;
using Eart.Persistencia.DAL;

namespace Eart.Areas.Membros.Controllers
{
    public class MembrosController : Controller
    {
        MembroDAL membroDAL = new MembroDAL();

        private ActionResult ObterVisaoMembroPorId(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membro membro = membroDAL.ObterMembroPorId((long) id);
            if (membro == null)
            {
                return HttpNotFound();
            }
            return View(membro);
        }

        private ActionResult GravarMembro(Membro membro)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    membroDAL.GravarMembro(membro);
                    
                }
                return View(membro);
            }
            catch
            {
                return View(membro);
            }
        }

        public ActionResult Index()
        {
            return View(membroDAL.ObterMembrosClassificadosPorNome());
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Membro membro)
        {
            GravarMembro(membro);
            return RedirectToAction("Edit", new { id = membro.MembroId });
        }

        // Get: Edit
        public ActionResult Edit(long? id)
        {
            return ObterVisaoMembroPorId(id);
        }

        // POST: Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Membro membro)
        {
            GravarMembro(membro);
            return RedirectToAction("Index");
        }

    }
}